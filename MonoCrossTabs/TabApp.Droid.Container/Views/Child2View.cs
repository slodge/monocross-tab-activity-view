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
    [Activity(Label = "Child 2!")]
    public class Child2View : MXListActivityView<TabModel>
    {
        public override void Render()
        {
            ListView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, Model.SecondContent );
        }
    }
}