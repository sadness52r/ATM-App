using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    class DropDownController
    {
        public bool IsExpand { get; set; }
        public int MaxHeight { get; set; }
        public int MinHeight { get; set; }

        public DropDownController(bool isExpand, int maxHeight, int minHeight)
        {
            IsExpand = isExpand;
            MaxHeight = maxHeight;
            MinHeight = minHeight;
        }

        public void Open(ref FlowLayoutPanel flpDropDown, Timer timer)
        {
            flpDropDown.Height += 15;
            if (flpDropDown.Height >= MaxHeight)
            {
                timer.Stop();
                IsExpand = true;
            }
        }

        public void Close(ref FlowLayoutPanel flpDropDown, Timer timer)
        {
            flpDropDown.Height -= 15;
            if (flpDropDown.Height <= MinHeight)
            {
                timer.Stop();
                IsExpand = false;
            }
        }
    }
}
