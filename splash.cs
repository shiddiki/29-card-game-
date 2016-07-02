using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace _29_card
{
    public partial class splash : Form
    {
        System.IO.Stream files;
        public splash()
        {
            InitializeComponent();

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            files =
                thisExe.GetManifestResourceStream("_29_card.back.sp.jpg");
            pictureBox1.Image= Image.FromStream(files);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            label1.BackColor = Color.Transparent;
            label1.Text = "";
            progressBar1.Height = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            progressBar1.Visible = true;
            
            this.progressBar1.Value = this.progressBar1.Value + 5;
            if (this.progressBar1.Value == 6)
            {
                label1.BackColor = Color.Transparent;
                label1.Text = "Extracting Resources...";
            }
            else if (this.progressBar1.Value == 10)
            {
                label1.BackColor = Color.Transparent;
                label1.Text = "Gathering Information...";
            }
            else if (this.progressBar1.Value == 20)
            {
                label1.BackColor = Color.Transparent;
                label1.Text = "Loading Game Data...";
            }
            else if (this.progressBar1.Value == 25)
            {
                label1.BackColor = Color.Transparent;
                label1.Text = "Starting...";
            }
            else if (this.progressBar1.Value == 30)
            {
                label1.BackColor = Color.Transparent;
                label1.Text = "Starting...";
            }
            else if (this.progressBar1.Value >= 30) //35
            {

                this.progressBar1.Value = 38;
                timer1.Enabled = false;
                this.Hide();
                new Form1().Show();
                
            }
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void splash_Load_1(object sender, EventArgs e)
        {
            //the timer is going to start
            progressBar1.Height = 5;
            //timer1.Start();
        }
    }
}
