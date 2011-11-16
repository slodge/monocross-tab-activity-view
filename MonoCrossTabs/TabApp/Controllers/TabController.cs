using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoCross.Navigation;
using TabApp.Model;

namespace TabApp.Controllers
{
    public class TabController : MXController<TabModel>
    {
        public override string Load(Dictionary<string, string> parameters)
        {
            Model = new TabModel();
            return ViewPerspective.Default;
        }
    }
}
