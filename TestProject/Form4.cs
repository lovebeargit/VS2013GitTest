using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TestProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void add()
        {
            DateTime beginTime = DateTime.Now;
            long minValue = long.Parse(textBox1.Text.ToString());
            long maxValue = long.Parse(textBox2.Text.ToString());
            int threadNumber = Convert.ToInt32(textBox3.Text);
            int threadOrder = Convert.ToInt32(Thread.CurrentThread.Name);

            long step = (maxValue - minValue + 1) / threadNumber;
            long beginValue = minValue + step * (threadOrder - 1);
            long endValue = beginValue + step;
            long result = 0;
            for (long i = beginValue; i < endValue; i++)
            {
                result += i;
            }
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - beginTime;
            string message = "线程" + Thread.CurrentThread.Name + ":" + beginValue.ToString() + "到" + endValue.ToString() + ", 耗时:" + timeSpan.TotalMilliseconds.ToString() + "毫秒";
            this.listBox1.Items.Add(message);
            Thread.CurrentThread.Abort();



        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(add);
            Thread t = new Thread(ts);
            t.Start();
        }
    }
}
