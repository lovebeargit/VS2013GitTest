using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            char[] c = n.ToCharArray();
            string temp = string.Empty;
            int k = 0;
            for (int i = n.Length-1; i >=0; i--)
            {
                temp+=c[k];
                if (i % 3 == 0 && i!=0)
                {
                    temp += ",";
                }
                k++;
            }
            textBox1.Text = temp;
        }
    }
}
