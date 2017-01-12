using _30015379_DWA_Project.Common;
using System;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Bing.Maps;
using System.Linq;
using Windows.UI;
using Windows.Devices.Geolocation;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Http;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace _30015379_DWA_Project
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Maps : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        Point point;
        int count;
        LocationCollection pinCol = new LocationCollection();
        List<string> WayPoints = new List<string>();

        private readonly string BingMapsKey = "OR29En2Jl2GSLBLMnv3l~FYc0fOi0dZenpENs7n3z5g~Anl3c2gHq_UVd3NfCSpnfZuWh2Z2_D29cHAkZoDgdQjGHcgEg66rSidnTngg0hFW";

        private readonly XNamespace BingMapsNamespace = "http://schemas.microsoft.com/search/local/ws/rest/v1";

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public Maps()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        
        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="Common.NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="Common.NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        async private void getDirection(Location location)
        {
            try
            {
                WayPoints.Add(string.Format("{0}, {1}", location.Latitude, location.Longitude));

                if (this.WayPoints.Count < 2) return;

                HttpClient client = new HttpClient();
                StringBuilder builder = new StringBuilder("http://dev.virtualearth.net/REST/V1/Routes/Driving?o=xml&");

                for (int index = 0; index < this.WayPoints.Count(); index++)
                {
                    builder.Append(string.Format("wp.{0}={1}&", index, this.WayPoints[index]));
                }

                builder.Append("avoid-minimizeTolls&key=");
                builder.Append(this.BingMapsKey);
                HttpResponseMessage response = await client.GetAsync(builder.ToString());

                response.EnsureSuccessStatusCode();
                Stream stream = await response.Content.ReadAsStreamAsync();

                XDocument document = XDocument.Load(stream);

                var query = from p in document.Descendants(this.BingMapsNamespace + "maneuverPoint")
                            select new
                            {
                                Latitude = p.Element(this.BingMapsNamespace + "Latitude").Value,
                                Longitude = p.Element(this.BingMapsNamespace + "Longitude").Value
                            };

                MapShapeLayer layer = new MapShapeLayer();
                MapPolyline polyline = new MapPolyline();
                foreach (var item in query)
                {
                    double latitude, longitude;

                    double.TryParse(item.Latitude, out latitude);
                    double.TryParse(item.Longitude, out longitude);

                    polyline.Locations.Add(new Location(latitude, longitude));
                }

                polyline.Color = Colors.Red;
                polyline.Width = 5;
                layer.Shapes.Add(polyline);
                this.MyMap.ShapeLayers.Add(layer);
                var distance = (from d in document.Descendants(this.BingMapsNamespace + "TravelDistance") select d).First().Value;

                double trueDistance = ConvertDistance(Convert.ToDouble(distance));

                Coordinatesbox.Text = (string.Format("{0} km", trueDistance.ToString()));
            }
            catch (Exception ex)
            {
                Coordinatesbox.Text = "Error! Cannot reach destination!";
            }
        }

        private double ConvertDistance(double miles)
        {
            return Math.Round(miles * 1.60934, 2);
            
        }

        private void MyMap_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            point = e.GetPosition(MyMap);
            
            var position = e.GetPosition(MyMap);

            Location location;

            if(MyMap.TryPixelToLocation(position, out location))
            {
                Pushpin pin = new Pushpin();

                MapLayer.SetPosition(pin, location);
                pin.Text = (++count).ToString();
                MyMap.Children.Add(pin);
                MyMap.SetView(location);
                pinCol.Add(location);
                drawLine();
                getDirection(location);
            }
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Remove_Pins_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var pins = from pin in MyMap.Children select pin;
            var pinsarray = pins.ToArray();
            for (int i = 0; i < pinsarray.Count(); i++)
            {
                MyMap.Children.Remove(pinsarray[i]);
            }
            MyMap.ShapeLayers.Clear();
            pinCol.Clear();
            count = 0;
            Coordinatesbox.Text = "";
            WayPoints.Clear();
        }

        private void drawLine()
        {
            MapShapeLayer shape = new MapShapeLayer();
            MapPolyline line = new MapPolyline();
            line.Width = 5;
            line.Color = Colors.Red;
            line.Locations = pinCol;
            shape.Shapes.Add(line);
            MyMap.ShapeLayers.Add(shape);

        }

        
    }
}
