using _30015379_DWA_Project.Common;
using _30015379_DWA_Project.Data;
using System;
using System.Windows;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.DataTransfer;
using System.Collections.ObjectModel;
using Windows.Storage;
using System.Text;
using Newtonsoft.Json;



// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace _30015379_DWA_Project
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Favourites : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private ObservableCollection<SampleDataItem> favsSDI = new ObservableCollection<SampleDataItem>();
        private ObservableCollection<SampleDataItem> listSDI = new ObservableCollection<SampleDataItem>();
        SampleDataItem selectedItem;
        

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
        
        public Favourites()
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
        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
         
           
            var groups = await SampleDataSource.GetGroupsAsync();
            foreach (var group in groups)
            {
                for (int i = 0; i < group.Items.Count; i++)
                {
                    listSDI.Add(group.Items[i]);
                }   
            }
            this.DefaultViewModel["Groups"] = groups;
            itemGridView.ItemsSource = listSDI;

            var folder = ApplicationData.Current.LocalFolder;
            var file = await folder.GetFileAsync("FavouritesList.json");
            using (var stream = await file.OpenStreamForReadAsync())
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                string json = await reader.ReadToEndAsync();
                var collection = JsonConvert.DeserializeObject<ObservableCollection<SampleDataItem>>(json);
                favsSDI = collection;
            }

            favoriteGridView.ItemsSource = favsSDI;
            
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

        void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Navigate to the appropriate destination page, configuring the new page
            // by passing required information as a navigation parameter
            var itemId = ((SampleDataItem)e.ClickedItem).UniqueId;
            this.Frame.Navigate(typeof(ItemDetailPage), itemId);
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

        private void itemGridView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            selectedItem = (SampleDataItem)e.Items[0];
        }

        private void favoriteGridView_Drop(object sender, DragEventArgs e)
        {
            if (favsSDI.Contains(selectedItem) != true)
            {
                favsSDI.Add(selectedItem);
                favoriteGridView.ItemsSource = favsSDI;
            }
        }

        private void drag_out(object sender, DragItemsStartingEventArgs e)
        {
            selectedItem = (SampleDataItem)e.Items[0];

            favsSDI.Remove(selectedItem);
        }

        private async void Save(object sender, RoutedEventArgs e)
        {
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.CreateFileAsync("FavouritesList.json", CreationCollisionOption.ReplaceExisting);
            using (var stream = await file.OpenStreamForWriteAsync())
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            {
                string json = JsonConvert.SerializeObject(favsSDI);
                await writer.WriteAsync(json);
            }
        }

        private async void Delete(object sender, RoutedEventArgs e)
        {
            favsSDI.Clear();

            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.GetFileAsync("FavouritesList.json");
            using (var stream = await file.OpenStreamForWriteAsync())
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            {
                string json = JsonConvert.SerializeObject(favsSDI);
                await writer.WriteAsync(json);
            }

            favoriteGridView.ItemsSource = favsSDI;
        }
    }
}
