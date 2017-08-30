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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            change();
            Displaycost();
        }

         public int change()
        {
            int cost;
            string peopleNum;
            peopleNum = domainUpDown1.Text.ToString();
            bool fancy;
            if (checkBox1.Checked)
                fancy = true;
            else
                fancy = false;
            bool health;
            if (checkBox2.Checked)
                health = true;
            else
                health = false;
            cost= calculate(Convert.ToInt32(peopleNum), health, fancy);
            return cost;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Displaycost()
        {
            textBox1.Text = change().ToString();
        }
        public int calculate(int peopleNum,bool health,bool fancy)
        {
            int sum=0;
            sum = peopleNum * 25;
            if (health)
                sum = sum + peopleNum * 5;
            if (fancy)
                sum = sum + peopleNum * 15; 
            return sum;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            change();
            Displaycost();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            change();
            Displaycost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            change();
            Displaycost();
        }

    
    }
}
