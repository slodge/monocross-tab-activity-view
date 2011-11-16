using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;

using MonoCross.Navigation;
using MonoCross.Droid;
using TabApp.Model;

namespace TabApp.Droid.Container
{
    [BroadcastReceiver]
    [IntentFilter(new string[] { "MonoCross.MainReceiver.b339ad1b-8828-4bc7-b534-574ee42c7637" })]
    public class MainReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            // initialize app
            MXDroidContainer.Initialize(new TabApp.App(), context.ApplicationContext);

            // initialize views
            MXDroidContainer.AddView<TabModel>(typeof(Views.TabView), ViewPerspective.Default);

            // navigate to first view
            MXDroidContainer.Navigate(null, MXContainer.Instance.App.NavigateOnLoad);
        }
    }
}