using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Reflection;

namespace _29_card
{
    class saved
    {
        public static string one = "South", two = "East", three = "North", four = "West", line;
        public static string backg = "_29_card.back.gr.jpg";
        System.IO.Stream file;
        public saved()
        {

        }

        public void getinfo()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "_29_card.savet.txt";

            String local = Environment.CurrentDirectory;
            string ppath=local+"\\29_card.txt";
            
            if (File.Exists(@ppath))
            {
                //MessageBox.Show("yes");
              
            }
            else
            {
               // File.Create(@ppath);

                //FileStream fs = File.Create("29_card.txt");
                //fs.Close();

                File.Create(@ppath).Close();


                TextWriter tw = new StreamWriter(@ppath);
                tw.WriteLine("South");
                tw.WriteLine("East");
                tw.WriteLine("North");
                tw.WriteLine("West");
                tw.WriteLine("_29_card.back.gr.jpg");
               // tw.WriteLine("1");
                tw.Close();

               
                
               

            }


            int ii = 1;
            int chk = 0;
            try
            {


                using (System.IO.StreamReader file = new System.IO.StreamReader(@ppath))
            {
                    one = "";
                    two = "";
                    three = "";
                    four = "";
                    backg = "";
                     chk = 0;
                    while (ii<=5)
                        {
                            // Do some stuff here with your textfile

                            line = file.ReadLine();

                            if (line == ""||line==null)
                                chk = 1;
                            if (line.Length > 10&&ii<=4)
                            {line = line.Substring(0, 9);
                            
                            }

                            if (ii == 1)
                                one += line;
                            else if (ii == 2)
                                two += line;
                            else if (ii == 3)
                                three += line;
                            else if (ii == 4)
                                four += line;
                            else if (ii == 5)
                                backg += line;

                            if (ii == 5)
                            {
                                if (line != "_29_card.back.c1.jpg" && line != "_29_card.back.co.jpg" && line != "_29_card.back.col.jpg" && line != "_29_card.back.fn.jpg" && line != "_29_card.back.gl.jpg" && line != "_29_card.back.gr.jpg" && line != "_29_card.back.mt.jpg" && line != "_29_card.back.sp.jpg" && line != "_29_card.back.w2.jpg" && line != "_29_card.back.wo1.jpg" && line != "_29_card.back.wo3.jpg")
                                    chk = 1;
                            
                            }
                            ii++;
                            line = "";
                        }

                   
                
            }
                 
              
            }
            catch
            { 
            
            }

            if (chk == 1)
            {
                one = "South";
                two = "East";
                three = "North";
                four = "West";
                backg = "_29_card.back.gr.jpg";

                TextWriter tw = new StreamWriter(@ppath);
                tw.WriteLine("South");
                tw.WriteLine("East");
                tw.WriteLine("North");
                tw.WriteLine("West");
                tw.WriteLine("_29_card.back.gr.jpg");
                tw.Close();

              /*  try
                {
                    File.SetAttributes(
                    "29_card.txt",
                    FileAttributes.Archive |
                   // FileAttributes.Hidden |
                    FileAttributes.ReadOnly
                    );

                }
                catch { }
               * */
            }
        }
    }


}
