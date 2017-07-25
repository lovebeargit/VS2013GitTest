using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        private void button2_Click(object sender, EventArgs e)
        {
             int[] a = new int[10];
             Random r = new Random();
             int j;             
            for (int i = 0; i < 10; i++)
            {
                j = r.Next(0, a.Length+1);
                if (a.Contains(j))
                {
                    i--;
                    continue;
                }
                else
                {
                    a[i] = j;
                }

            }
            comboBox1.DataSource = a;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string xml = textBox2.Text.ToString();
            Student s = new Student();
            //s=xmlToData(xml);
            
        }
        public string name;
        private void button4_Click(object sender, EventArgs e)
        {
            name = textBox3.Text.ToString();
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
            
        }
       // public Student xmlToData(string xml)
        //{
            
            //XmlSerializer serializer = new XmlSerializer(typeof(Student));
            //return (Student)serializer.Deserialize(new StringReader(xml));
        //}
    }
}
