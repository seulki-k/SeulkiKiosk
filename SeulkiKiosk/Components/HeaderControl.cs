using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeulkiKiosk.Components
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        public string Title { get => lblTitle.Text; set => lblTitle.Text  = value; }

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))] // Description을 멀티라인으로 작성하게끔 사용

        public string Description { get => lblDescription.Text; set => lblDescription.Text = value; }


    }
}
