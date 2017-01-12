using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Windows.ApplicationModel.Background;
using Windows.Storage;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using System.IO;

namespace BackgroundTask
{
    public sealed class NotificationBackgroundTask : IBackgroundTask
    {
        

        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            BackgroundTaskDeferral deferral = taskInstance.GetDeferral();

            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile textFile = await folder.CreateFileAsync("toBeRead.txt", CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(textFile, "Background Notification Successful!");
            
            deferral.Complete();
        }
    }
}
