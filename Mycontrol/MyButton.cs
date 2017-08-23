using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mycontrol
{
    public class MyButton:Button
    {

        Label lable = null;
        public MyButton()
        {
            lable = new Label();
            lable.Location = new System.Drawing.Point(0, 25);
            lable.Text = "Hello";

            this.Height = 50;
            this.Width = 100;
            
            this.Controls.Add(lable);
        }
    }
}
