using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _29_card
{
    public partial class setname : Form
    {
        public setname()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String local = Environment.CurrentDirectory;
            string ppath = local + "\\29_card.txt";

            try
            {
                if (File.Exists(@ppath))
                {
                    //MessageBox.Show("yes");
                    TextWriter twq = new StreamWriter(ppath);
                    twq.WriteLine(textBox1.Text);
                    twq.WriteLine(textBox2.Text);
                    twq.WriteLine(textBox3.Text);
                    twq.WriteLine(textBox4.Text);
                    twq.WriteLine(saved.backg);
                    saved.one = textBox1.Text;
                    saved.two = textBox2.Text;
                    saved.three = textBox3.Text;
                    saved.four = textBox4.Text;

                    twq.Close();

                }
                else
                {
                    // File.Create(@ppath);

                    TextWriter tww = new StreamWriter(@ppath);
                    tww.WriteLine("South");
                    tww.WriteLine("East");
                    tww.WriteLine("North");
                    tww.WriteLine("West");
                    tww.Close();


                }
            }
            catch (Exception ert) { MessageBox.Show(ert.ToString()); }

            if (textBox4.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "")
                MessageBox.Show("Please Give Names to All players!!");
            else
            this.Close();
        }

        private void setname_Load(object sender, EventArgs e)
        {
            textBox1.Text = saved.one;
            textBox2.Text = saved.two;
            textBox3.Text = saved.three;
            textBox4.Text = saved.four;
        }
        
    }
}
