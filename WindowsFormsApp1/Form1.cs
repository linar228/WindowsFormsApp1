using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          switch(textBox1.Text)
          {
                case "Circle" : Form2 FCirc = new Form2();
                                FCirc.Show();
                                break;
                case "Line": Form3 FLine = new Form3();
                             FLine.Show();
                             break;
                case "Triangle": Form4 FTrian = new Form4();
                                 FTrian.Show();
                                 break;
                case "Rectangle": Form5 FRect = new Form5();
                                  FRect.Show();
                                  break;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 FCirc = new Form2();
            FCirc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 FLine = new Form3();
            FLine.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 FTrian = new Form4();
            FTrian.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 FRect = new Form5();
            FRect.Show();
        }
    }
}
