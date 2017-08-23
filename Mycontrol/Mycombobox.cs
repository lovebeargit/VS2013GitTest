using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycontrol
{
    public class Mycombobox:ComboBox
    {

        public CheckBox cb = null;
        public Label lb = null;
        public Mycombobox()
        {
            this.Size = new System.Drawing.Size(100,20);
            cb = new CheckBox();
            cb.Size = new System.Drawing.Size(20,20);
            cb.Location = new System.Drawing.Point(0,0);
            this.Controls.Add(cb);

            lb = new Label();
            lb.Size = new System.Drawing.Size(80,20);
            lb.Location = new System.Drawing.Point(20,0);
            this.Controls.Add(lb);                
            

        }
    }
}
