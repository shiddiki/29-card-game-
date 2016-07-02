using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _29_card
{
    public partial class calling : Form
    {
        public calling()
        {
            InitializeComponent();
        }
        Form1 fm = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            base1.call[1] = 16;
            base1.lastcall = 16;
            base1.highbider = 1;
            this.Close();
            //cl.Hide();
            if (base1.left == 1)
            {
                int x = base1.left + 1;
                while (base1.cc[x] != 1)
                { x++; if (x == 5) x = 1; }
                //set_call se = new set_call();
                //se.setcall(x);
                //Form1 fm = new Form1();
                fm.setcall(x);
                if (base1.passes == 3)
                    return;
            }
            else
            {

               // set_call se = new set_call();
               // se.setcall(set_call.left );
                //Form1 fm = new Form1();
                fm.setcall(base1.left);
                if (base1.passes == 3)
                    return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base1.call[1] = 17;
            base1.lastcall = 17;
            base1.highbider = 1;
            this.Close();
            //cl.Hide();
            if (base1.left == 1)
            {
                int x = base1.left + 1;
                while (base1.cc[x] != 1)
                { x++; if (x == 5) x = 1; }
                //set_call se = new set_call();
                //se.setcall(x);
               // Form1 fm = new Form1();
                fm.setcall(x);
                if (base1.passes == 3)
                    fm.sec();
            }
            else
            {

                //set_call se = new set_call();
                //se.setcall(set_call.left);
               // Form1 fm = new Form1();
                fm.setcall(base1.left);
                if (base1.passes == 3)
                    fm.sec();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            base1.call[1] = 18;
            base1.lastcall = 18;
            base1.highbider = 1;
            this.Close();
            //cl.Hide();
            if (base1.left == 1)
            {
                int x = base1.left + 1;
                while (base1.cc[x] != 1)
                { x++; if (x == 5) x = 1; }
                //set_call se = new set_call();
                //se.setcall(x);
               // Form1 fm = new Form1();
                fm.setcall(x);
                if (base1.passes == 3)
                    fm.sec();
            }
            else
            {

                //set_call se = new set_call();
               // se.setcall(set_call.left);
               // Form1 fm = new Form1();
                fm.setcall(base1.left);
                if (base1.passes == 3)
                    fm.sec();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //set_call se = new set_call();
            base1.passes++;
            base1.cc[1] = 0;
            base1.left = base1.right;
            int x = base1.left + 1;
            if (x >= 5) x = 1;
            while (base1.cc[x] != 1&&base1.passes!=3)
           { x++; if (x == 5) x = 1; }
            base1.right = x;
           int ri = Right;
           this.Close();
           //se.setcall(ri);
          // Form1 fm = new Form1();
           fm.setcall(ri);
           if (base1.passes == 3)
               fm.sec();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            base1.call[1] = 19;
            base1.lastcall = 19;
            base1.highbider = 1;
            this.Close();
            //cl.Hide();
            if (base1.left == 1)
            {
                int x = base1.left + 1;
                while (base1.cc[x] != 1)
                { x++; if (x == 5) x = 1; }
                //set_call se = new set_call();
                //se.setcall(x);
              //  Form1 fm = new Form1();
                fm.setcall(x);
                if (base1.passes == 3)
                    fm.sec();

            }
            else
            {

                //set_call se = new set_call();
                //se.setcall(set_call.left);
               // Form1 fm = new Form1();
                fm.setcall(base1.left);
                if (base1.passes == 3)
                    fm.sec();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            set_call.call[1] = 20;
            set_call.lastcall = 20;
            set_call.highbider = 1;
            this.Close();
            //cl.Hide();
            if (set_call.left == 1)
            {
                int x = set_call.left + 1;
                while (set_call.cc[x] != 1)
                { x++; if (x == 5) x = 1; }
                //set_call se = new set_call();
                //se.setcall(x);
              //  Form1 fm = new Form1();
                fm.setcall(x);
                if (base1.passes == 3)
                    fm.sec();
            }
            else
            {

                //set_call se = new set_call();
                //se.setcall(set_call.left);
                //Form1 fm = new Form1();
                fm.setcall(base1.left);
                if (base1.passes == 3)
                    fm.sec();
            }
        }
    }
}
