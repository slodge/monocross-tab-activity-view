using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TabApp.Model
{
    public class TabModel
    {
        public List<string> FirstContent { get; set; }
        public List<string> SecondContent { get; set; }
        public List<string> ThirdContent { get; set; }

        public TabModel()
        {
            FirstContent = "Hello world from MonoCross!".Split(' ').ToList();
            SecondContent = "Cross platform code in C#".Split(' ').ToList();
            ThirdContent = "With MXTabActivityView, you can Tab the night away".Split(' ').ToList();
        }
    }
}