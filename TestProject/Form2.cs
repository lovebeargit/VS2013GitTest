using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            label1.Text += f1.name;

            this.Size = new Size(500, 500);
            this.userpanel1.pb.Image = Image.FromFile(@"\..\pic\1.PNG");
           
            this.userpanel1.lb1.Text = "Name";
            this.userpanel1.lb2.Text = "thelastmessage";
            this.userpanel1.lb3.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
           

            //this.mysearch1.pb.Image = Image.FromFile("s.PNG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(textBox1.Text.ToString());
            long fib=Fibonacci(l);
            label3.Text = fib.ToString();
        }
        public long Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
