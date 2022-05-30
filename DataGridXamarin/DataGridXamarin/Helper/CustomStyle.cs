using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataGridXamarin
{
    public class Customstyle : DataGridStyle
    {
        public Customstyle()
        {
        }
        public override Color GetSwitchOnColor()
        {
            return Color.Red;
        }
        public override Color GetSwitchOffColor()
        {
            return Color.Blue;
        }
    }
}
