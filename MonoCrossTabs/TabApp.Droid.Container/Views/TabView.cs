using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using MonoCross.Navigation;
using MonoCross.Droid;
using TabApp.Model;

namespace TabApp.Droid.Container.Views
{
    [Activity(Label = "Tab View!")]
    public class TabView : MXTabActivityView<TabModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TabHost);

            TabHost.TabSpec spec;     // Resusable TabSpec for each tab
            Intent intent;            // Reusable Intent for each tab

            // Create an Intent to launch an Activity for the tab (to be reused)
            // Then initialize a TabSpec for each tab and add it to the TabHost

            intent = new Intent(this, typeof(Child1View));
            intent.AddFlags(ActivityFlags.NewTask);

            spec = TabHost.NewTabSpec("child1");
            spec.SetIndicator("One", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(Child2View));
            intent.AddFlags(ActivityFlags.NewTask);

            spec = TabHost.NewTabSpec("child2");
            spec.SetIndicator("Two", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
            spec.SetContent(intent);
            TabHost.AddTab(spec);

            intent = new Intent(this, typeof(Child3View));
            intent.AddFlags(ActivityFlags.NewTask);

            spec = TabHost.NewTabSpec("child3");
            spec.SetIndicator("Three", Resources.GetDrawable(Resource.Drawable.ic_tab_artists));
            spec.SetContent(intent);
            TabHost.AddTab(spec);
        }

        public override void Render()
        {
            // nothing to do
        }
    }
}