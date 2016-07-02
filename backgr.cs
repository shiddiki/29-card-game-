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
    public partial class backgr : Form
    {
        public static int sel = 0;
        System.IO.Stream file;
        public backgr()
        {
            InitializeComponent();
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            file =
                thisExe.GetManifestResourceStream("_29_card.back.gr.jpg");
            this.BackgroundImage = Image.FromStream(file);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            string[] resources = thisExe.GetManifestResourceNames();
            string list = "";

            



            //System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.c1.jpg");
            this.pictureBox1.Image = Image.FromStream(Form1.fileb);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //thisExe = System.Reflection.Assembly.GetExecutingAssembly();

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.co.jpg");
            this.pictureBox2.Image = Image.FromStream(Form1.fileb);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            //thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.col.jpg");
            this.pictureBox3.Image = Image.FromStream(Form1.fileb);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.fn.jpg");
            this.pictureBox4.Image = Image.FromStream(Form1.fileb);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.gl.jpg");
            this.pictureBox5.Image = Image.FromStream(Form1.fileb);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.gr.jpg");
            this.pictureBox6.Image = Image.FromStream(Form1.fileb);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.mt.jpg");
            this.pictureBox7.Image = Image.FromStream(Form1.fileb);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.w2.jpg");
            this.pictureBox8.Image = Image.FromStream(Form1.fileb);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.wo1.jpg");
            this.pictureBox9.Image = Image.FromStream(Form1.fileb);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;

            Form1.fileb = thisExe.GetManifestResourceStream("_29_card.back.wo3.jpg");
            this.pictureBox10.Image = Image.FromStream(Form1.fileb);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox1.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.c1.jpg");
            base1.backimg = "_29_card.back.c1.jpg";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox2.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.co.jpg");
            base1.backimg = "_29_card.back.co.jpg";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox3.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.col.jpg");
            base1.backimg = "_29_card.back.col.jpg";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox4.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.fn.jpg");
            base1.backimg = "_29_card.back.fn.jpg";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox5.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
               thisExe.GetManifestResourceStream("_29_card.back.gl.jpg");
            base1.backimg = "_29_card.back.gl.jpg";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox6.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.gr.jpg");
            base1.backimg = "_29_card.back.gr.jpg";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox7.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.mt.jpg");
            base1.backimg = "_29_card.back.mt.jpg";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox8.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.w2.jpg");
            base1.backimg = "_29_card.back.w2.jpg";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox9.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.wo1.jpg");
            base1.backimg = "_29_card.back.wo1.jpg";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            this.BackgroundImage = pictureBox10.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Form1.fileb =
                thisExe.GetManifestResourceStream("_29_card.back.wo3.jpg");
            base1.backimg = "_29_card.back.wo3.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sel = 1;
            this.Close();
        }

       
    }
}
