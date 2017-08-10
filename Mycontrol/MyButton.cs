using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycontrol
{
    public  class MyButton : UserControl
    {
        Label lable = null;
        public MyButton()
        {
            //InitializeComponent();
            lable = new Label();
            lable.Location = new System.Drawing.Point(0, 0);
            lable.Width = 60;
            lable.Height = 30;
            lable.Text = "Honey";

            this.Controls.Add(lable);
        }
    }
}
