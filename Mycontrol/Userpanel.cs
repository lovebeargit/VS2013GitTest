using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycontrol
{
    public class Userpanel:Panel
    {
        public PictureBox pb = null;
        public Label lb1, lb2, lb3, lb4 = null;
        public Userpanel()
        {
            this.Width = 150;
            this.Height = 50;
            pb = new PictureBox();
            pb.Location = new System.Drawing.Point(0, 0);
            pb.Size = new System.Drawing.Size(50, 50);
            //pb.Image = Image.FromFile("1.png");
            this.Controls.Add(pb);
            lb1 = new Label();
            lb1.Location = new Point(50, 0);
            lb1.Size = new Size(80, 25);
            lb1.Font = new Font("宋体", 9, FontStyle.Bold);
            
            this.Controls.Add(lb1);
            lb2 = new Label();
            lb2.Location = new Point(50, 25);
            lb2.Size = new Size(100, 25);
           
            this.Controls.Add(lb2);
            lb3 = new Label();
            lb3.Location = new Point(130, 0);
            lb3.Size = new Size(70, 25);
            
            this.Controls.Add(lb3);

        }
    }
}
