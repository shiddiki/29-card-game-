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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "_29_card.help.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    richTextBox1.Text = result;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
