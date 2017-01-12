using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _30015379_DWS_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        SystemTrigger internetTrigger = new SystemTrigger(SystemTriggerType.InternetAvailable, false);
        MaintenanceTrigger timeTrigger = new MaintenanceTrigger(15, false);
        SystemCondition condition = new SystemCondition(SystemConditionType.UserPresent);
        

        public MainPage()
        {
            this.InitializeComponent();
            RegisterBackgroundTask("BackgroundTask.NotificationBackgroundTask", "NotificationTask", timeTrigger);
        }

        

        public BackgroundTaskRegistration RegisterBackgroundTask(string taskEntryPoint, string name, IBackgroundTrigger trigger)
        {
            var taskRegistered = false;


            foreach (var cur in BackgroundTaskRegistration.AllTasks)
            {
                if (cur.Value.Name == name)
                {
                    taskRegistered = true;
                    break;
                }
            }

            var builder = new BackgroundTaskBuilder();

            builder.Name = name;
            builder.TaskEntryPoint = taskEntryPoint;
            builder.SetTrigger(trigger);

            BackgroundTaskRegistration task = builder.Register();
            
            return task;
        }


        private void goToCamera(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Camera), null);
        }

        private async void executeBackgroundServices(object sender, RoutedEventArgs e)
        {
            try
            {
                StorageFolder folder = ApplicationData.Current.LocalFolder;
                StorageFile file = await folder.GetFileAsync("toBeRead.txt");

                string read = await FileIO.ReadTextAsync(file);

                MessageDialog msg = new MessageDialog(read);
                await msg.ShowAsync();
            }
            catch
            {
                MessageDialog errorMsg = new MessageDialog("File not found");
                await errorMsg.ShowAsync();
            }
        }

        private void goToCreateAlbum(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PhotoPage), null);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }



}

