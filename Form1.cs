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

   
    public partial class Form1 : Form
    {
        System.IO.Stream file;
        System.IO.Stream bcfile;
        System.IO.Stream music;
        public static System.IO.Stream fileb;
        public static string ffile = "_29_card.res.";

     
         
        public static string path = "";
        int card = 1,cal=0;
        int nowcall,trm;
        public static int called, passed,thisislastseven;
        public static string callpoint = "";
        public static string mytr = "";
        //for set call
        
        int fs = 0, se = 0, th = 0, fo = 0;
        int aa;

        public static int uspo = 0;
       public static int pcpo = 0;
        //
        public Form1()
        {
            InitializeComponent();
            
            

            Control.CheckForIllegalCrossThreadCalls = false;
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            file =
                thisExe.GetManifestResourceStream(saved.backg);
            this.BackgroundImage = Image.FromStream(file);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            
           chklebc();

            file =
                thisExe.GetManifestResourceStream(ffile+"tt.png");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;

            pictureBox14.Image = Image.FromStream(file);
            pictureBox14.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox15.Image = Image.FromStream(file);
            pictureBox15.SizeMode = PictureBoxSizeMode.CenterImage;
            button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled=false;
                disablepb();
                label5.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label18.Text = "";

                

                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
                richTextBox3.Visible = false;

                button2.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
            
               // changeToolStripMenuItem.Enabled = false;    

                label1.Text = saved.one;
                label2.Text = saved.two;
                label3.Text = saved.three;
                label4.Text = saved.four;
        }

        Thread stc;
        Thread strt;
        private void label18_Click(object sender, EventArgs e)
        {

        }


        public void trumpset()
        {
           

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            file =
                thisExe.GetManifestResourceStream("_29_card.res.tt.png");
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            button6.Enabled = false;
            if (base1.highbider == 1)
            {
                Set_Trumph st = new Set_Trumph();
                st.StartPosition = FormStartPosition.CenterParent;
                st.ShowDialog(this);
              
            }
            else
            {

               
                base1.tselected = 1;

                string pplli = "";
                if (base1.highbider == 1)
                    pplli = saved.one;
                if (base1.highbider == 2)
                    pplli = saved.two;
                if (base1.highbider == 3)
                    pplli = saved.three;
                if (base1.highbider == 4)
                    pplli = saved.four;

                label5.Text = pplli+" is setting the Trump.";
                int ye = 0;
                this.Refresh();
                while(ye!=2)
                {
                    Thread.Sleep(700);
                ye++;

                }
            }

            if (base1.tselected == 1)
            {
                pictureBox13.Image = Image.FromStream(file);
                
            }
            this.Refresh();
            button2.Enabled = true;
            base1.trmsel = 1;



            
            

            getsechalf();
        
        }
      
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Get First half
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (base1.gamerunning == 0)
                base1.gamerunning = 1;

            


            dispose();

          

                        thisislastseven = 0;
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            try
            { 
                stc.Abort(); //if comes back from setcall
                
                
            }
            catch
            {
               
            }

            try
            {
                strt.Abort(); //if comes back from setcall

               
            }
            catch
            {
                
            }

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            startSoundPlayer();
            

            button8.Enabled = false;
            base1.passes = 0;
            //int[] card = new card;

            fs = 0; se = 0; th = 0; fo = 0; //gives card

            ////////////////////////Cleaning table

            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            


            ////////////////////////
            base1.arr4[0] = "11.png";
            base1.arr4[1] = "12.png";
            base1.arr4[2] = "13.png";
            base1.arr4[3] = "14.png";
            base1.arr4[4] = "15.png";
            base1.arr4[5] = "16.png";
            base1.arr4[6] = "17.png";
            base1.arr4[7] = "18.png";
            base1.arr4[8] = "31.png";
            base1.arr4[9] = "32.png";
            base1.arr4[10] = "33.png";
            base1.arr4[11] = "34.png";
            base1.arr4[12] = "35.png";
            base1.arr4[13] = "36.png";
            base1.arr4[14] = "37.png";
            base1.arr4[15] = "38.png";
            base1.arr4[16] = "41.png";
            base1.arr4[17] = "42.png";
            base1.arr4[18] = "43.png";
            base1.arr4[19] = "44.png";
            base1.arr4[20] = "45.png";
            base1.arr4[21] = "46.png";
            base1.arr4[22] = "47.png";
            base1.arr4[23] = "48.png";
            base1.arr4[24] = "21.png";
            base1.arr4[25] = "22.png";
            base1.arr4[26] = "23.png";
            base1.arr4[27] = "24.png";
            base1.arr4[28] = "25.png";
            base1.arr4[29] = "26.png";
            base1.arr4[30] = "27.png";
            base1.arr4[31] = "28.png";

            Random r = new Random();
            int rInt = r.Next(0, 32); //for ints

            
            

            base1 bs = new base1();

            nowcall =  base1.firstcaller;
            
            
                for (int cd = 1; cd <= 4; cd++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        //Thread.Sleep(500);
                        path = "_29_card.res.";


                        while (base1.arr4[rInt] == "")
                        {
                            rInt = r.Next(0, 31);
                        }
                        string pa = "";
                        pa = base1.arr4[rInt];
                        aa = Convert.ToInt32(base1.arr4[rInt].Substring(0, 2));
                        base1.arr4[rInt] = "";

                        if (cd == 1)
                        {
                            base1.firstc[fs++] = aa;
                        }
                        else if (cd == 2)
                        {
                            base1.secondc[se++] = aa;
                        }
                        else if (cd == 3)
                        {
                            base1.thirdc[th++] = aa;
                        }
                        else if (cd == 4)
                        {
                            base1.forthc[fo++] = aa;
                        }

                      
                    }
                }
                if (card == 1)//first 4 card
                {
                ///shoing 4 card
                Array.Sort(base1.firstc); Array.Sort(base1.secondc); Array.Sort(base1.thirdc); Array.Sort(base1.forthc);

                       // label5.Text = nowcall.ToString();
                string tmp="";
                string pa = "";
                tmp=Convert.ToString(base1.firstc[4]);

                        pa=@path+tmp+".png";
                        file =
                           thisExe.GetManifestResourceStream(pa);
                        pictureBox7.Image = Image.FromStream(file);
                        tmp = Convert.ToString(base1.firstc[5]);
                        pa = @path + tmp + ".png";

                        file =
                               thisExe.GetManifestResourceStream(pa);
                        pictureBox8.Image = Image.FromStream(file);
                        tmp = Convert.ToString(base1.firstc[6]);
                        pa = @path + tmp + ".png";

                        file =
                               thisExe.GetManifestResourceStream(pa);
                        pictureBox9.Image = Image.FromStream(file);
                        tmp = Convert.ToString(base1.firstc[7]);

                        pa = @path + tmp + ".png";
                        file =
                            thisExe.GetManifestResourceStream(pa);
                        pictureBox10.Image = Image.FromStream(file);
                        this.Refresh();
                
                    
                        int trya;
                        ////
                       // if (base1.time == 0)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                base1.cc[i] = 1;
                                base1.call[i] = 0;
                                base1.trumph[i] = 0;
                            }
                            base1.lastcall = 15;
                            base1.passes = 0;
                            base1.time++;
                        }

                        ////
                  
                        base1.left = nowcall;
                        base1.firstcaller = nowcall;
                       // setcall(nowcall);
                    if(base1.bidding==1)
                    {
                        string hb = set_call.highbider.ToString();
                           
                    }


                card = 2;
            }//first 4 card end
            else
            {
                
            }
               
            string op="";
                for (int t = 2; t <= 4; t++)
                { op="";
                    for(int crd=4;crd<=7;crd++)
                    {
                        if (t == 2)
                        {
                            int cardt = base1.secondc[crd]/10;
                            int cadrp = base1.secondc[crd] % 10;
                            if (cardt == 1)
                                op += "Heart ";
                            if (cardt == 2)
                                op += "Club ";
                            if (cardt == 3)
                                op += "Dice ";
                            if (cardt == 4)
                                op += "Spade ";

                            if(cadrp==1)
                                op += "7\n";
                            if (cadrp == 2)
                                op += "8\n";
                            if (cadrp == 3)
                                op += "Queen\n";
                            if (cadrp == 4)
                                op += "King\n";
                            if (cadrp == 5)
                                op += "10\n";
                            if (cadrp == 6)
                                op += "A\n";
                            if (cadrp == 7)
                                op += "9\n";
                            if (cadrp == 8)
                                op += "jack\n";
                            richTextBox1.Text = op;
                        }
                        if (t == 3)
                        {
                            int cardt = base1.thirdc[crd] / 10;
                            int cadrp = base1.thirdc[crd] % 10;
                            if (cardt == 1)
                                op += "Heart ";
                            if (cardt == 2)
                                op += "Club ";
                            if (cardt == 3)
                                op += "Dice ";
                            if (cardt == 4)
                                op += "Spade ";

                            if (cadrp == 1)
                                op += "7\n";
                            if (cadrp == 2)
                                op += "8\n";
                            if (cadrp == 3)
                                op += "Queen\n";
                            if (cadrp == 4)
                                op += "King\n";
                            if (cadrp == 5)
                                op += "10\n";
                            if (cadrp == 6)
                                op += "A\n";
                            if (cadrp == 7)
                                op += "9\n";
                            if (cadrp == 8)
                                op += "jack\n";
                            richTextBox2.Text = op;
                        }
                        if (t == 4)
                        {
                            int cardt = base1.forthc[crd] / 10;
                            int cadrp = base1.forthc[crd] % 10;
                            if (cardt == 1)
                                op += "Heart ";
                            if (cardt == 2)
                                op += "Club ";
                            if (cardt == 3)
                                op += "Dice ";
                            if (cardt == 4)
                                op += "Spade ";

                            if (cadrp == 1)
                                op += "7\n";
                            if (cadrp == 2)
                                op += "8\n";
                            if (cadrp == 3)
                                op += "Queen\n";
                            if (cadrp == 4)
                                op += "King\n";
                            if (cadrp == 5)
                                op += "10\n";
                            if (cadrp == 6)
                                op += "A\n";
                            if (cadrp == 7)
                                op += "9\n";
                            if (cadrp == 8)
                                op += "jack\n";
                            richTextBox3.Text = op;
                        }

                    }
                
                }
            
            
            //check if play is ok

            int jc=0,po=0,poles=0,forjack=0,NOTGO=0;
            int []ar=new int[10];
            for(int i=1;i<=4;i++)
            {   jc=0;po=0;
                if(i==1)    Array.Copy(base1.firstc,ar,base1.firstc.Length);
                if(i==2)    Array.Copy(base1.secondc,ar,base1.secondc.Length);
                if(i==3)    Array.Copy(base1.thirdc,ar,base1.thirdc.Length);
                if(i==4)    Array.Copy(base1.forthc,ar,base1.forthc.Length);

                for(int j=0;j<=7;j++)
                {if(ar[j]%10==8)jc++;
                    po+=base1.point[ar[j]%10];}
                if(jc==4)
                    forjack=i;
                if(po==0&&i==nowcall)       //no point in first hand
                    poles=i;
            
            }
           
            if(forjack>0||poles>0)
            {
                if (poles == 1)
                {
                    DialogResult result1 = MessageBox.Show(" Do You Want To Continue??", "You Don't Have Any Point in First Hand.", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.No)
                    NOTGO = 1;
                }
                if (poles > 1)
                {NOTGO = 1;
                label5.Text = "Firsthand got no point. Get New Deal!!";
                }
                if (forjack > 0)
                {NOTGO = 1;
                label5.Text = "One Player Got 4 Jacks. Get New Deal!!";
                }
            }
          

            if (NOTGO == 1)    //not ==continue
            {
                button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                disablepb();
                getcard.Enabled = true;
                
                card = 1;
            }
            else
            {
                getcard.Enabled = false;
                button5.Enabled=true;

                string ppll = "";
                if (base1.roundfirst == 1)
                    ppll = saved.one;
                if (base1.roundfirst == 2)
                    ppll = saved.two;
                if (base1.roundfirst == 3)
                    ppll = saved.three;
                if (base1.roundfirst == 4)
                    ppll = saved.four;

                label5.Text="Set Bid. First Bidder "+ppll;

                //setting call
                base1.right = nowcall;
                button5.Enabled = false;

                stc = new Thread(() => setcall(nowcall));
                stc.Start();
                
                
            }


        }

        

        /// <summary>
        /// Set Call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click(object sender, EventArgs e)
        {
            base1.right = nowcall;
            button5.Enabled = false;
            setcall(nowcall);
            

        }


        


        /// <summary>
        /// AI calling
        /// </summary>
        /// <param name="nowcall"></param>
        public void setcall(int nowcall)
        {


            
            //Thread.Sleep(1000);

            Random r = new Random();
            int rInt = r.Next(0, 32);


            int low = base1.lastcall + 1; int high = 0; int call; int samec = 0;
            base1.totalpoint = 0; int kq = 0; int jack = 0; int nine = 0, ind;
            int lowthanqueen=0;
            // conditions start
            if (base1.passes < 3&&nowcall<=4 &&cal!=1)
            {
                
                if (nowcall != 1)
                {
                    

                    int[] fl = new int[10];

                    if (nowcall== 2)
                        Array.Copy(base1.secondc, fl, 8);
                    else if (nowcall == 3)
                        Array.Copy(base1.thirdc, fl, 8);
                    else if (nowcall == 4)
                        Array.Copy(base1.forthc, fl, 8);

                    int hr=0, sp=0, cl=0, dc = 0,snn=0,boro=0,boroc=0;
                    for (int i = 0; i <= 7; i++)  //which card how many
                    { 
                        if(fl[i]!=0&&fl[i]/10==1)
                            hr++;
                             if(fl[i]!=0&&fl[i]/10==2)
                                 cl++;
                                  if(fl[i]!=0&&fl[i]/10==4)
                                      sp++;
                                  if (fl[i] != 0 && fl[i] / 10 == 3)
                                      dc++;
                                  if (fl[i] != 0 && fl[i] % 10 > boro)
                                  { boro = fl[i] % 10; boroc = fl[i] / 10; }
                    
                    }
                    
                    if (hr > samec)         //saving maximum no card in samec and as trump typ
                    {samec = hr;snn=1;}
                    if (sp > samec)
                    {samec = sp;snn=4;}
                    if (dc > samec)
                    {samec = dc; snn = 3;}
                    if (cl > samec)
                    {samec = cl; snn = 2;}

                    if (samec==2&&hr!=1&&sp!=1&&dc!=1&&cl!=1)  {

                        snn = boroc;
                    
                    }
                        
                     for(int i=1;i<=4;i++)       //counting tot point in hand
                        {
                            if (nowcall == 2)
                            base1.totalpoint += base1.point[base1.secondc[i + 3] % 10];
                        if (nowcall == 3)
                            base1.totalpoint += base1.point[base1.thirdc[i + 3] % 10];
                        if (nowcall == 4)
                            base1.totalpoint += base1.point[base1.forthc[i + 3] % 10];

                        }   


                           
                        if (samec >= 2 && base1.totalpoint >= 3&&nowcall!=3&&pcpo>=-2)
                        {
                            high = 16;

                          
                            base1.trumph[nowcall] = snn;


                        }

                    //2nd  same typ >=3 &&totalpoint>=4
                    if (samec >= 3&&base1.totalpoint>=4)
                    {
                        base1.trumph[nowcall] = snn;
                        high = 18;

                        if (nowcall == 3)
                            high = 17;
                        //checking marriage 
                        for (int k = 4; k <= 7; k++)
                        {
                            if (nowcall == 2)
                            {

                                if (base1.secondc[k] == base1.trumph[nowcall] * 10 + 3 || base1.secondc[k] == base1.trumph[nowcall] * 10 + 4)
                                    kq++;
                                else if (base1.secondc[k] == base1.trumph[nowcall] * 10 + 8)
                                    jack = 1;
                                else if (base1.secondc[k] == base1.trumph[nowcall] * 10 + 7)
                                    nine = 1;
                                else if (base1.secondc[k] < base1.trumph[nowcall] * 10 + 3)
                                    lowthanqueen = 1;
                            }
                            else if (nowcall == 3)
                            {

                                if (base1.thirdc[k] == base1.trumph[nowcall] * 10 + 3 || base1.thirdc[k] == base1.trumph[nowcall] * 10 + 4)
                                    kq++;
                                else if (base1.thirdc[k] == base1.trumph[nowcall] * 10 + 8)
                                    jack = 1;
                                else if (base1.thirdc[k] == base1.trumph[nowcall] * 10 + 7)
                                    nine = 1;
                                else if (base1.thirdc[k] < base1.trumph[nowcall] * 10 + 3)
                                    lowthanqueen = 1;

                            }
                            else if (nowcall == 4)
                            {
                                if (base1.forthc[k] == base1.trumph[nowcall] * 10 + 3 || base1.forthc[k] == base1.trumph[nowcall] * 10 + 4)
                                    kq++;
                                else if (base1.forthc[k] == base1.trumph[nowcall] * 10 + 8)
                                    jack = 1;
                                else if (base1.forthc[k] == base1.trumph[nowcall] * 10 + 7)
                                    nine = 1;
                                else if (base1.forthc[k] < base1.trumph[nowcall] * 10 + 3)
                                    lowthanqueen = 1;


                            }


                        }


                        
                        
                        

                        
                        //2nd rule      
                        if (jack == 1 && nine == 1 && samec >= 2)
                        { high = 18; 
                            
                        
                        }

                        //3rd rule
                        if (jack == 1 && nine == 1 && samec >= 3)
                        {high = 20;
                        if (nowcall == 3)
                            high = 19;
                        }

                        //applying..
                        if (base1.totalpoint >= 1 && kq == 2 && lowthanqueen == 1)//king queen ache, kq er nicher ekta card ache..
                        {
                            rInt = r.Next(0, 32);
                            if (rInt > 20 && rInt < 25)
                                high = 20;
                            if (rInt >= 25 && rInt <= 29)
                                high = 21;
                            if (rInt > 29 && rInt <= 31)
                                high = 22;
                            if (rInt <= 20)
                                high = 19;

                            if (base1.lastcall < 18)            //for starting calling from 18
                                base1.lastcall = 18;
                        }

                        

                    }

                    //applying rule no 2
                    if ((samec <= 2 && base1.totalpoint >= 6 && nowcall != 3) || (uspo == 5 && pcpo > -5)) //pc calling in seventh card
                    {
                        high = 18;

                        int[] pcseven = new int[8];

                        if (nowcall == 2)
                            Array.Copy(base1.secondc, pcseven, base1.secondc.Length);

                        if (nowcall == 4)
                            Array.Copy(base1.forthc, pcseven, base1.forthc.Length);

                        int maxmmc = 0;
                        for (int i = 0; i <= 7; i++)
                            if (pcseven[i] % 10 > maxmmc)
                            {
                                maxmmc = pcseven[i] % 10;
                                base1.trumph[nowcall] = pcseven[i] / 10;
                            }


                    }

                    //condition ends
                    if(base1.passes<3)
                    {
                        if (nowcall == 2)
                        label9.Text = "Thinking...";
                    if (nowcall == 3)
                        label8.Text = "Thinking...";
                    if (nowcall == 4)
                        label7.Text = "Thinking...";
                }
                    Random rt = new Random();
                    int rii=0;
                    Thread.Sleep(1000);
                    this.Refresh();
                    
                    

                 


                    if (high > base1.lastcall)
                    {
                        ind = nowcall;
                        int indu = nowcall;
                        base1.lastcall++;
                        //set_call.call[ind] = lastcall;
                        base1.call[indu] = base1.lastcall;
                        base1.highbider = nowcall;

                        string hb = set_call.highbider.ToString();
                        int du = base1.call[Convert.ToInt32(hb)];
                       // MessageBox.Show(hb + Convert.ToString(du));

                        if (nowcall == 2)
                            label9.Text = "call " + base1.lastcall.ToString();
                        if (nowcall == 3)
                            label8.Text = "call " + base1.lastcall.ToString();
                        if (nowcall == 4)
                            label7.Text = "call " + base1.lastcall.ToString();
                        if (nowcall == base1.left )//|| base1.cc[base1.left] == 0)
                        {
                            int x = base1.left + 1;
                            if (x == 5) x = 1;
                            while (base1.cc[x] != 1)
                            { x++; if (x == 5) x = 1; }
                            base1.right = x;
                           // MessageBox.Show(Convert.ToString(base1.right));
                            if (base1.passes < 3)
                            {
                                if (base1.right == 2)
                                    label9.Text = "Thinking...";
                                if (base1.right == 3)
                                    label8.Text = "Thinking...";
                                if (base1.right == 4)
                                    label7.Text = "Thinking...";
                            }
                            this.Refresh();
                            Thread.Sleep(1000);
                            setcall(base1.right);

                        }
                        else
                        {
                            if (base1.passes < 3)
                            {if (base1.left == 2)
                                label9.Text = "Thinking...";
                            if (base1.left == 3)
                                label8.Text = "Thinking...";
                            if (base1.left == 4)
                                label7.Text = "Thinking...";
                        }
                            this.Refresh();
                            Thread.Sleep(1000);
                            setcall(base1.left);

                        }

                    }
                    else                                                                   //pass.......................call
                    {
                        string hb = set_call.highbider.ToString();
                        int du = base1.call[Convert.ToInt32(hb)];
                        
                        if (nowcall == 2)
                            label9.Text = "Pass.";
                        if (nowcall == 3)
                            label8.Text = "Pass.";
                        if (nowcall == 4)
                            label7.Text = "Pass.";
                        base1.passes++;
                        if (base1.passes == 3 && base1.lastcall == 15)
                        {
                            label5.Text = "Oops! Three Players have Passed!!\n Get New Deal!!";
                            button2.Enabled=false;
                            getcard.Enabled = true;
                            card = 1;
                            nowcall++;
                            if (nowcall == 5)
                                nowcall = 1;
                            
                            return;
                        }
                        if (base1.passes == 3)
                            base1.bidding = 1;
                        int x;
                        base1.cc[nowcall] = 0;
                    
                        if (base1.highbider == 0)
                        {
                            base1.left++;
                            x = base1.left;
                            if (base1.left == 5)
                                base1.left = 1;

                            if (x == 5) x = 1;
                        }
                        else
                        {
                            base1.left = base1.highbider;
                            x = base1.highbider + 1;
                        
                        
                        }
                        if (base1.left == 5)
                            base1.left = 1;
                      
                        
                         
                        if (x == 5) x = 1;
                        while (base1.cc[x] != 1 && base1.passes != 3)
                        {
                            x++;
                            if (x == 5) x = 1;
                        }
                        base1.right = x;
                        if(base1.passes<3)
                        {if (base1.right == 2)
                            label9.Text = "Thinking...";
                        if (base1.right == 3)
                            label8.Text = "Thinking...";
                        if (base1.right == 4)
                            label7.Text = "Thinking...";}
                        this.Refresh();
                        Thread.Sleep(1000);
                        setcall(base1.right);




                    }

                }
                else
                {
                    

                   
                    called = 0; passed = 0; callpoint = "";
                    

                    stcall sss = new stcall();
                    sss.StartPosition = FormStartPosition.CenterParent;
                    sss.ShowDialog();
                    Refresh();
                        if (called == 1)
                        {
                            label18.Text = callpoint;
                            if (label18.Text.Length == 2)
                            {
                                cal = 2;
                                base1.call[1] = Convert.ToInt32(label18.Text);
                                base1.lastcall = Convert.ToInt32(label18.Text);
                                base1.highbider = 1;
                                //this.Close();
                                //cl.Hide();
                                if (base1.left == 1)
                                {
                                    int x = base1.left + 1;
                                    if (x == 5) x = 1;
                                    while (base1.cc[x] != 1)
                                    { x++; if (x == 5) x = 1; }
                                    
                                    setcall(x);
                                    if (base1.passes == 3 && base1.lastcall == 15)
                                    {
                                        label5.Text = "Oops! Three Players have Passed!!\n Get New Deal!!";
                                        getcard.Enabled = true;
                                        card = 1;
                                        nowcall++;
                                        if (nowcall == 5)
                                            nowcall = 1;
                                        //base1 bs = new base1();
                                        return;

                                    }
                                    else if (base1.passes == 3)
                                    {
                                        string lc = "";
                                        if (base1.highbider == 1)
                                            lc = saved.one;
                                        if (base1.highbider == 2)
                                            lc = saved.two;
                                        if (base1.highbider == 3)
                                            lc = saved.three;
                                        if (base1.highbider == 4)
                                            lc = saved.four;
                                        this.Refresh();
                                        if(base1.trmsel==0)
                                        {label5.Text = "Calling Ends.";
                                        //groupBox1.Enabled = false;
                                        button6.Enabled = true;

                                        
                                        trumpset();
                                        }



                                        return;
                                    }
                                }
                                else
                                {

                                   
                                    int x = base1.left;
                                    if (x == 5) x = 1;
                                    while (base1.cc[x] != 1)
                                    { x--; if (x == 0) x = 4; }
                                   
                                    setcall(x);

                                    if (base1.passes == 3 && base1.lastcall == 15)
                                    {
                                        label5.Text = "Oops! Three Players have Passed!!\n Get New Deal!!";
                                        card = 1;
                                        getcard.Enabled = true;
                                        nowcall++;
                                        if (nowcall == 5)
                                            nowcall = 1;
                                        //base1 bs = new base1();
                                        return;
                                    }
                                    else if (base1.passes == 3)
                                    {
                                        string lc = "";
                                        if (base1.highbider == 1)
                                            lc = saved.one;
                                        if (base1.highbider == 2)
                                            lc = saved.two;
                                        if (base1.highbider == 3)
                                            lc = saved.three;
                                        if (base1.highbider == 4)
                                            lc = saved.four;
                                        if (base1.trmsel == 0)
                                            label5.Text = "Calling Ends.";
                                        //groupBox1.Enabled = false;
                                        button6.Enabled = true;
                                        this.Refresh();
                                        
                                        if (base1.trmsel == 0)
                                        trumpset();
                                        return;
                                    }
                                }
                            }
                            else
                                setcall(1);
                            if (button2.Enabled == true)        //get 2nd half button
                                return;
                        
                        }
                        else if (passed == 1)
                        {
                            cal = 2;
                            base1.passes++;
                            base1.cc[1] = 0;

                            // if (base1.left == 1)
                            base1.left = base1.highbider;
                            if (base1.firstcaller == 1 && base1.lastcall == 15)
                            {
                                base1.left = 2;
                                setcall(base1.left);
                            }
                            int x = base1.left + 1;
                            if (x >= 5) x = 1;
                            if (x == 5) x = 1;
                            while (base1.cc[x] != 1 && base1.passes != 3)
                            { x++; if (x == 5) x = 1; }
                            base1.right = x;
                            //base1.left = base1.right;
                            int ri = base1.right;
                            
                         
                            setcall(ri);
                            if (base1.passes == 3)
                            {
                                string lc = "";
                                if (base1.highbider == 1)
                                    lc = saved.one;
                                if (base1.highbider == 2)
                                    lc = saved.two;
                                if (base1.highbider == 3)
                                    lc = saved.three;
                                if (base1.highbider == 4)
                                    lc = saved.four;
                                if (base1.passes == 3 && base1.lastcall == 15)
                                {
                                    label5.Text = "Oops! Three Players have Passed!!\n Get New Deal!!";
                                    getcard.Enabled = true;
                                    card = 1;
                                    nowcall++;
                                    if (nowcall == 5)
                                        nowcall = 1;
                                    // base1 bs = new base1();
                                    return;
                                }
                                else
                                {
                                    if (base1.trmsel == 0)
                                    label5.Text = "Calling Ends";
                                    //groupBox1.Enabled = false;
                                    
                                    if (base1.trmsel == 0)
                                    trumpset();
                                    this.Refresh();
                                    button6.Enabled = true;
                                }
                                return;
                            }
                        }

                    //.....................


                    label18.Text = "";
                    //groupBox1.Enabled = true;
                    cal = 1;
                    
                    

                }
                return;

            }//
        }


        public void getsechalf()
        {

            

            label8.Text = "";
            label9.Text = "";
            label7.Text = "";
            label20.Text = "";
            label21.Text = "";
            label18.Text = "";
           
            if(base1.highbider==1&&base1.trumph[1]==0)
                label5.Text = "Trump selected on Seventh Card...";
            else
            label5.Text = "Game Starts...";

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();

            button2.Enabled = false;
            string pa = "";
            Random r = new Random();
            int rInt = r.Next(0, 32);
            int tempu;
            //reverse sort

            int lim = 16;
                int sevenn=0;
            int[] tmpr = new int[52];
            for (int iii = 0; iii < 32; iii++)
            {
                if (base1.arr4[iii] == "")
                    tmpr[iii] = 0;
                else
                {

                    tmpr[iii] = iii;
                }
            }

            //if(base1.firstc[ii]
            Array.Reverse(base1.firstc);
            Array.Reverse(base1.secondc);
            Array.Reverse(base1.thirdc);
            Array.Reverse(base1.forthc);


            fs = 4; se = 4; th = 4; fo = 4;







            //




            for (int cd = 1; cd <= 4; cd++)
            {
                for (int i = 0; i < 4; i++)
                {
                    //Thread.Sleep(500);
                    path = "_29_card.res."; 

                    Array.Sort(tmpr);
                    Array.Reverse(tmpr);

                    while (base1.arr4[tmpr[rInt]] == "")
                    {
                        rInt = r.Next(0, lim);
                    }
                    int y = tmpr[rInt];
                    tmpr[rInt] = 0;
                    rInt = y;
                    string tt = base1.arr4[rInt];
                    pa = "";
                    pa += tt[0].ToString();
                    pa += tt[1].ToString();
                    aa = Convert.ToInt32(base1.arr4[rInt].Substring(0, 2));
                    base1.arr4[rInt] = "";
                    //tmpr[rInt] = 0;
                    lim--;
                    if (cd == 1)
                    {
                        base1.firstc[fs++] = aa;
                        if (base1.highbider == 1 && base1.trumph[1] == 0 && i == 2)
                        {
                            base1.trumph[1] = aa / 10;
                            sevenn=1;
                            base1.seventhcard =  aa;////////////////////////////////seventh card selection
                        }
                    }
                    else if (cd == 2)
                    {
                        base1.secondc[se++] = aa;
                    }
                    else if (cd == 3)
                    {
                        base1.thirdc[th++] = aa;
                    }
                    else if (cd == 4)
                    {
                        base1.forthc[fo++] = aa;
                    }


                }
            }

            





            Array.Sort(base1.firstc); 
            Array.Sort(base1.secondc); Array.Sort(base1.thirdc); Array.Sort(base1.forthc);

           // label5.Text = path;
            
            
            string tmp = "";
            pa = "";
            tmp = Convert.ToString(base1.firstc[0]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox5.Image = Image.FromStream(file);

            pa = "";
            tmp = Convert.ToString(base1.firstc[1]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox6.Image = Image.FromStream(file);


            pa = "";
            tmp = Convert.ToString(base1.firstc[2]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox7.Image = Image.FromStream(file);

            pa = "";
            tmp = Convert.ToString(base1.firstc[3]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox8.Image = Image.FromStream(file);

            pa = "";
            tmp = Convert.ToString(base1.firstc[4]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox9.Image = Image.FromStream(file);

            pa = "";
            tmp = Convert.ToString(base1.firstc[5]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox10.Image = Image.FromStream(file);

            pa = "";
            tmp = Convert.ToString(base1.firstc[6]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox11.Image = Image.FromStream(file);

            pa = "";
            tmp = Convert.ToString(base1.firstc[7]);
            pa = @path + tmp + ".png";
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox12.Image = Image.FromStream(file);

            card = 1;


            


          






           for(int cc=1;cc<=4;cc++)     //initially setting all cards are on hand
               for(int d=1;d<=8;d++)
                   base1.onhandc[cc,d]=1;

           trm = 0;

           int jacki = 0,notgo=0,jget=0,notpoint=0,npp=0;
             int opon1, opon2,gottrump=0;
            if (base1.highbider == 1 || base1.highbider == 3)
            { opon1 = 2; opon2 = 4; }
            else
            { opon1 = 1; opon2 = 3; }
            
           int[] ar = new int[10];
           int trumm;
           if (sevenn == 1)
               trumm = base1.seventhcard / 10;
           else
               trumm=base1.trumph[base1.highbider];
           for (int i = 1; i <= 4; i++)
           {
               jacki = 0;
               notpoint=0;
               if (i == 1) Array.Copy(base1.firstc, ar, base1.firstc.Length);
               if (i == 2) Array.Copy(base1.secondc, ar, base1.secondc.Length);
               if (i == 3) Array.Copy(base1.thirdc, ar, base1.thirdc.Length);
               if (i == 4) Array.Copy(base1.forthc, ar, base1.forthc.Length);

               jacki = 0;
               for (int j = 0; j <= 7; j++)
               {if (ar[j] % 10 == 8) 
                   jacki++;
               if(ar[j]%10>=5)
               notpoint++;
               
                   if((i==opon2||i==opon1)&&ar[j]/10==trumm)   //oppponent er trump ache kina
                       gottrump=1;
               }

               if (jacki == 4||notpoint==0)
                   notgo = 1;
               if(notpoint==0)
                   npp=1;
           }

           int cont = 0;
           if (notgo == 1||gottrump==0)
           {    if(jacki==4)
               MessageBox.Show(this,"One Player have 4 jack in hand!!!\n Get New Deal.");
                else if(npp==1)
               MessageBox.Show(this,"Player Don't Have Point in 8 Card!!!\n Get New Deal.");
                else
               MessageBox.Show(this,"Opponent Player Don't Have Trump Card in 8 Cards!!!\n Get New Deal.");
               getcard.Enabled = true;
               card = 1;
               cont = 1;
           }
           else
           {
               button7.Enabled = true;
               cont = 0;
           }
           int spoint = 0,sevcard=0;
            if(sevenn==1)
            {
                for(int i=0;i<=7;i++)
                {if(base1.firstc[i]/10==base1.seventhcard/10&&base1.firstc[i]%10>=5)
                        spoint=1;
                if (base1.firstc[i] / 10 == base1.seventhcard / 10)
                    sevcard++;
                }
            
            }

            if(sevenn==1)
            {
                int su=base1.seventhcard;

                string ss = "";
                if (su / 10 == 1) ss += "Hearts ";
                if (su / 10 == 2) ss += "Clubs ";
                if (su / 10 == 3) ss += "Dice ";
                if (su / 10 == 4) ss += "Spade ";
                if(su%10==1)
                    ss += "Seven";
                if (su % 10 == 2)
                    ss += "Eight";
                if (su % 10 == 3)
                    ss += "Queen";
                if (su % 10 == 4)
                    ss += "King";
                if (su % 10 == 5)
                    ss += "Ten";
                if (su % 10 == 6)
                    ss += "Ace";
                if (su % 10 == 7)
                    ss += "Nine";
                    if (su % 10 == 8)
                        ss += "Jack";
                    MessageBox.Show(this,"Your Seventh Card is "+ss+". \n You Can't Play This Card Till The Trump Card is Shown!!!");

                   /* DialogResult dg;
                    
                        dg = MessageBox.Show(this, "Are you sure?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                */
                  

                if(spoint==0)
            {
                 MessageBox.Show(this,"You Don't Have Point of Trump Card in hand!!!\n Get New Deal.");
               getcard.Enabled = true;
               disablepb();
               card = 1;
               cont = 1;
            
            }
                else if (sevcard == 1)
                {
                    MessageBox.Show(this, "You Don't Have any Trump Card in hand!!!\n Get New Deal.");
                    getcard.Enabled = true;
                    disablepb();
                    card = 1;
                    cont = 1;

                }

            }
            

            if (cont == 0)
            {
                button7.Enabled = false;
                button8.Enabled = true;
                enablepb();

                

                strt = new Thread(start);
                strt.Start();

               //start();
            }
            else
            {
                button7.Enabled = true;
                label5.Text = "Get New First Deal!!";
                getcard.Enabled = true;
                card = 1;
                cont = 1;
            }
            return;
        }


        

        
        Thread t;

        private void button7_Click(object sender, EventArgs e)
        {
            

            button7.Enabled = false;
            button8.Enabled = true ;
            enablepb();
            

            
   
                start();
                
                
            
        }                       //game starts


        /// <summary>
        /// Starting game
        /// </summary>

        public void start()
        {
             
           // label19.Text = base1.trumph[base1.highbider].ToString();///////////////////////delete this

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();

             string pplli = "";
                    if (base1.highbider == 1)
                        pplli = saved.one;
                    if (base1.highbider == 2)
                        pplli = saved.two;
                    if (base1.highbider == 3)
                        pplli = saved.three;
                    if (base1.highbider == 4)
                        pplli = saved.four;

                    label12.Text = pplli;
            label13.Text=base1.call[base1.highbider].ToString();

            
            
            AI ai = new AI();       //this is needed to refresh ai's values
            Thread t;
            

            if (base1.cardpd <= 31)
            {
                if (base1.cardpd % 4 == 0) ////////////.......................chek who gets this round and set first playre
                {
                    
                   // timer1_Tick();
                    
                   

                    ai.faltu();
                    int w8 = 0;
                    while (w8 != 2)
                    {
                        Thread.Sleep(100);
                        this.Refresh();
                        w8++;
                    }


                    this.Refresh();
                    //print();
                    label20.Text = "user " + base1.userpoint.ToString();
                    label21.Text = "pc " + base1.pcpoint.ToString();
                    //MessageBox.Show(" last round goes to"+base1.roundfirst.ToString());


                    string ppll = "";
                    if (base1.roundfirst == 1)
                        ppll = saved.one;
                    if (base1.roundfirst == 2)
                        ppll = saved.two;
                    if (base1.roundfirst == 3)
                        ppll = saved.three;
                    if (base1.roundfirst == 4)
                        ppll = saved.four;

                   
                        label5.Text="Firsthand "+ppll;

                        


                    pictureBox1.Image = null;
                    pictureBox2.Image = null;
                    pictureBox3.Image = null;
                    pictureBox4.Image = null;

                   

                    //if(base1.cardpd>0)
                    base1.cardplayer = base1.roundfirst;
                    base1.roundfc = 0;

                    if (base1.tshown == 1 && trm == 0)
                    {
                        button8.Enabled = false;
                        string pa;
                        pa = "";
                        pa += path + base1.trumph[base1.highbider].ToString() + ".png";

                        base1.tshown = 1;
                        file =
                            thisExe.GetManifestResourceStream(pa);
                        pictureBox13.Image = Image.FromStream(file);
                        pictureBox13.Invalidate();
                        pictureBox13.Update();
                        pictureBox13.Refresh();
                        this.Refresh();
                        //but
                        trm = 1;

                        Array.Clear(base1.aloowt, 0, base1.aloowt.Length);


                    }

                    Array.Clear(base1.onboard, 0, base1.onboard.Length);
                    Array.Clear(base1.aloowt, 0, base1.aloowt.Length);
                    this.Refresh();
                
                }

                if (base1.cardplayer == 1)
                {

                  
                    enablepb();

                }
                else
                {

                    disablepb();
                   
                    int placecard;
                    //Thread t ;

                    placecard=ai.pc(base1.cardplayer);
                    
                    

                    //print();

                    if (base1.roundfc == 0)
                        base1.roundfc = placecard;

                    base1.onboard[base1.cardplayer] = placecard;

                    //for showing trumcard instancely
                    if (base1.tshown == 1 && trm == 0)
                    {
                        string pat = "";
                        string patht = "_29_card.res.";
                        pat = "";
                        pat += patht  + base1.trumph[base1.highbider].ToString() + ".png";

                        file =
                        thisExe.GetManifestResourceStream(pat);
                        base1.tshown = 1;
                        pictureBox13.Image = Image.FromStream(file);
                        pictureBox13.Invalidate();
                        pictureBox13.Update();
                        pictureBox13.Refresh();
                        this.Refresh();
                        //but
                        trm = 1;

                        //Array.Clear(base1.aloowt, 0, base1.aloowt.Length);


                    }
                    //

                    //



                    string path = "_29_card.res.";
                    string pa = "";
                    pa += path  + placecard.ToString() + ".png";

                    if (base1.cardplayer == 2 && placecard!=88 && base1.cardpd<=31)
                    {
                        
                        base1.secondc[AI.selectedcardpos]=0;

                        file =
                        thisExe.GetManifestResourceStream(pa);
                        pictureBox2.Image = Image.FromStream(file);
                        pictureBox2.Invalidate();
                        pictureBox2.Update();

                        base1.cardplayer++;
                        base1.cardpd++;
                        if (base1.cardplayer == 5)
                            base1.cardplayer = 1;
                        //Thread.Sleep(4);
                        place_card();
                        this.Refresh();

                        

                        start();


                        
                        return;
                        
                    
                    }
                    if (base1.cardplayer == 3 && placecard != 88 && base1.cardpd <= 31)
                    {
                        file =
                thisExe.GetManifestResourceStream(pa);
                        base1.thirdc[AI.selectedcardpos] = 0;
                        pictureBox3.Image = Image.FromStream(file);
                    pictureBox3.Invalidate();
                    pictureBox3.Update();
                    base1.cardplayer++;
                    base1.cardpd++;
                    if (base1.cardplayer == 5)
                        base1.cardplayer = 1;
                    place_card();
                    this.Refresh();
                    
                    start();
                    
                    return;
                    
                    }
                    if (base1.cardplayer == 4 && placecard != 88 && base1.cardpd <= 31)
                    {
                        file =
                thisExe.GetManifestResourceStream(pa);
                        base1.forthc[AI.selectedcardpos] = 0;
                        pictureBox4.Image = Image.FromStream(file);
                    pictureBox3.Invalidate();
                    pictureBox3.Update();
                    int k = 0;
                    base1.cardplayer++;
                    base1.cardpd++;
                    if (base1.cardplayer == 5)
                        base1.cardplayer = 1;
                    place_card();
                    //Thread.Sleep(1000);
                    this.Refresh();
                    
                    start();
                    

                        return;
                    }

                   // string path = @"E:\visc#\WIN_forms_app\29-card\29-card\Resources\";
                   // string pa = "";
                    if(base1.tshown==1&&trm==0)
                    {
                        pa = "";
                        pa += path + base1.trumph[base1.highbider].ToString() + ".png";

                    base1.tshown = 1;
                    file =
                    thisExe.GetManifestResourceStream(pa);
                    pictureBox13.Image = Image.FromStream(file);
                    this.Refresh();
                        //but
                    trm = 1;
                    Array.Clear(base1.aloowt, 0, base1.aloowt.Length);
                    }


                    
                    
                    

                }
            }
            else
            {
                ai.faltu();


                int w8 = 0;
                while (w8 != 2)
                {
                    Thread.Sleep(100);
                    this.Refresh();
                    w8++;
                }
                
                //MessageBox.Show("new. last round goes to" + base1.roundfirst.ToString());

                string ppll = "";
                if (base1.roundfirst == 1)
                    ppll = saved.one;
                if (base1.roundfirst == 2)
                    ppll = saved.two;
                if (base1.roundfirst == 3)
                    ppll = saved.three;
                if (base1.roundfirst == 4)
                    ppll = saved.four;
                label5.Text = "Get New Deal!!";
                label10.Text = "Highest Bidder";
                label11.Text = "Bid";

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                //if(base1.cardpd>0)
                base1.cardplayer = base1.roundfirst;
                base1.roundfc = 0;
                Array.Clear(base1.onboard, 0, base1.onboard.Length);
                Array.Clear(base1.aloowt, 0, base1.aloowt.Length);
                this.Refresh();
                
                
                //MessageBox.Show("Get new card!");
                label5.Text = "Get New Deal!!";
                updatepointtable();
                label20.Text = "user " + base1.userpoint.ToString();
                label21.Text = "pc " + base1.pcpoint.ToString();
                //base1 ss = new base1();
                getcard.Enabled = true;
                card = 1;
            }
        
        
        }

       
        public void sec()
        {
            Random r = new Random();
            int rInt = r.Next(0, 32);
            int tempu;
            //reverse sort

            
                    
                //if(base1.firstc[ii]
                    Array.Reverse(base1.firstc);
                    Array.Reverse(base1.secondc);
                    Array.Reverse(base1.thirdc);
                    Array.Reverse(base1.forthc);


                    fs = 4; se = 4; th = 4; fo = 4;
                

            //

                    string pa = "";

            
            for (int cd = 1; cd <= 4; cd++)
            {
                for (int i = 0; i < 4; i++)
                {
                    //Thread.Sleep(500);
                    path = @"E:\visc#\WIN_forms_app\29-card\29-card\Resources\";
                    

                    while (base1.arr4[rInt] == "")
                    {
                        rInt = r.Next(0, 31);
                    }
                    string tt = base1.arr4[rInt];
                    pa = "";
                    pa += tt[0].ToString();
                    pa += tt[1].ToString();
                    aa = Convert.ToInt32(base1.arr4[rInt].Substring(0, 2));
                    base1.arr4[rInt] = "";

                    if (cd == 1)
                    {
                        base1.firstc[fs++] = aa;
                    }
                    else if (cd == 2)
                    {
                        base1.secondc[se++] = aa;
                    }
                    else if (cd == 3)
                    {
                        base1.thirdc[th++] = aa;
                    }
                    else if (cd == 4)
                    {
                        base1.forthc[fo++] = aa;
                    }


                }
            }

        Array.Sort(base1.firstc); Array.Sort(base1.secondc); Array.Sort(base1.thirdc); Array.Sort(base1.forthc);

        //label5.Text = path;
                string tmp = "";
                pa = "";
                tmp = Convert.ToString(base1.firstc[0]);
                pa = @path + tmp + ".png";
                pictureBox5.Image = Image.FromFile(@pa);

                tmp = Convert.ToString(base1.firstc[1]);
                pa = @path + tmp + ".png";
                pictureBox6.Image = Image.FromFile(@pa);

                tmp = Convert.ToString(base1.firstc[2]);
                pa = @path + tmp + ".png";
                pictureBox7.Image = Image.FromFile(@pa);

                tmp = Convert.ToString(base1.firstc[3]);
                pa = @path + tmp + ".png";
                pictureBox8.Image = Image.FromFile(@pa);

                tmp = Convert.ToString(base1.firstc[4]);
                pa = @path + tmp + ".png";
                pictureBox9.Image = Image.FromFile(@pa);

                tmp = Convert.ToString(base1.firstc[5]);
                pa = @path + tmp + ".png";
                pictureBox10.Image = Image.FromFile(@pa);

                tmp = Convert.ToString(base1.firstc[6]);
                pa = @path + tmp + ".png";
                pictureBox11.Image = Image.FromFile(@pa);

                tmp = Convert.ToString(base1.firstc[7]);
                pa = @path + tmp + ".png";
                pictureBox12.Image = Image.FromFile(@pa);

                card = 1;
                play pl = new play();
                pl.start();
        
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "hi";
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Set_Trumph str = new Set_Trumph(this);
        }
    
 

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (base1.firstc[0] != 0 && ((base1.roundfirst == 1 && base1.seventhcard == 0) || validofuser(base1.firstc[0])))
            {
                pictureBox1.Image = pictureBox5.Image;
                

                pictureBox5.Image = null;
                pictureBox1.Refresh();
                pictureBox5.Refresh();
                base1.cardplayer++;
                if (base1.cardplayer == 5)
                    base1.cardplayer = 1;
                base1.cardpd++;
                if (base1.roundfc == 0)
                    base1.roundfc = base1.firstc[0];
                if (base1.tshown == 0 && base1.firstc[0] / 10 == base1.trumph[base1.highbider])
                    base1.aloowt[1] = 1;
                base1.onboard[1] = base1.firstc[0];
                base1.onhandc[base1.firstc[0] / 10, base1.firstc[0] % 10] = 0;
                base1.number_of_card[base1.firstc[0] / 10]--;
                base1.firstc[0] = 0;
                disablepb();
                start();
                return;
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (base1.firstc[1] != 0 && ((base1.roundfirst == 1 && base1.seventhcard == 0) || validofuser(base1.firstc[1])))
            {
                pictureBox1.Image = pictureBox6.Image;
                pictureBox6.Image = null;
                pictureBox1.Refresh();
                pictureBox6.Refresh();
                base1.cardplayer++;
                if (base1.cardplayer == 5)
                    base1.cardplayer = 1;
                base1.cardpd++;
                if (base1.roundfc == 0)
                    base1.roundfc = base1.firstc[1];
                if (base1.tshown == 0 && base1.firstc[1] / 10 == base1.trumph[base1.highbider])
                    base1.aloowt[1] = 1;
                base1.onboard[1] = base1.firstc[1];
                base1.onhandc[base1.firstc[1] / 10, base1.firstc[1] % 10] = 0;
                base1.number_of_card[base1.firstc[1] / 10]--;
                base1.firstc[1] = 0;
                disablepb();
                start();
                return;
            }
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (base1.firstc[2] != 0 && ((base1.roundfirst == 1 && base1.seventhcard == 0) || validofuser(base1.firstc[2])))
            {
                pictureBox1.Image = pictureBox7.Image;
                pictureBox7.Image = null;
                pictureBox1.Refresh();
                pictureBox7.Refresh();
                base1.cardplayer++;
                if (base1.cardplayer == 5)
                    base1.cardplayer = 1;
                base1.cardpd++;
                if (base1.roundfc == 0)
                    base1.roundfc = base1.firstc[2];
                if (base1.tshown == 0 && base1.firstc[2] / 10 == base1.trumph[base1.highbider])
                    base1.aloowt[1] = 1;
                base1.onboard[1] = base1.firstc[2];
                base1.onhandc[base1.firstc[2] / 10, base1.firstc[2] % 10] = 0;
                base1.number_of_card[base1.firstc[2] / 10]--;
                base1.firstc[2] = 0;
                disablepb();
                start();
                return;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (base1.firstc[3] != 0 && ((base1.roundfirst == 1 && base1.seventhcard == 0) || validofuser(base1.firstc[3])))
            {
                pictureBox1.Image = pictureBox8.Image;
                pictureBox8.Image = null;
                pictureBox1.Refresh();
                pictureBox8.Refresh();
                base1.cardplayer++;
                if (base1.cardplayer == 5)
                    base1.cardplayer = 1;
                base1.cardpd++;
                if (base1.roundfc == 0)
                    base1.roundfc = base1.firstc[3];
                if (base1.tshown == 0 && base1.firstc[3] / 10 == base1.trumph[base1.highbider])
                    base1.aloowt[1] = 1;
                base1.onboard[1] = base1.firstc[3];
                base1.onhandc[base1.firstc[3] / 10, base1.firstc[3] % 10] = 0;
                base1.number_of_card[base1.firstc[3] / 10]--;
                base1.firstc[3] = 0;
                disablepb();
                start();
                return;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (base1.firstc[4] != 0 && ((base1.roundfirst == 1 && base1.seventhcard == 0) || validofuser(base1.firstc[4])))
            {
                pictureBox1.Image = pictureBox9.Image;
                pictureBox9.Image = null;
                pictureBox1.Refresh();
                pictureBox9.Refresh();
                base1.cardplayer++;
                if (base1.cardplayer == 5)
                    base1.cardplayer = 1;
                base1.cardpd++;
                if (base1.roundfc == 0)
                    base1.roundfc = base1.firstc[4];
                if (base1.tshown == 0 && base1.firstc[4] / 10 == base1.trumph[base1.highbider])
                    base1.aloowt[1] = 1;
                base1.onboard[1] = base1.firstc[4];
                base1.onhandc[base1.firstc[4] / 10, base1.firstc[4] % 10] = 0;
                base1.number_of_card[base1.firstc[4] / 10]--;
                base1.firstc[4] = 0;
                disablepb();
                start();
                return;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (base1.firstc[5] != 0 && ((base1.roundfirst == 1 && base1.seventhcard == 0) || validofuser(base1.firstc[5])))
            {
                pictureBox1.Image = pictureBox10.Image;
                pictureBox10.Image = null;
                pictureBox1.Refresh();
                pictureBox10.Refresh();
                base1.cardplayer++;
                if (base1.cardplayer == 5)
                    base1.cardplayer = 1;
                base1.cardpd++;
                if (base1.roundfc == 0)
                    base1.roundfc = base1.firstc[5];
                if (base1.tshown == 0 && base1.firstc[5] / 10 == base1.trumph[base1.highbider])
                    base1.aloowt[1] = 1;
                base1.onboard[1] = base1.firstc[5];
                base1.onhandc[base1.firstc[5] / 10, base1.firstc[5] % 10] = 0;
                base1.number_of_card[base1.firstc[5] / 10]--;
                base1.firstc[5] = 0;
                disablepb();
                start();
                return;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (base1.firstc[6] != 0 && ((base1.roundfirst == 1 && base1.seventhcard == 0) || validofuser(base1.firstc[6])))
            {
                pictureBox1.Image = pictureBox11.Image;
                pictureBox11.Image = null;
                pictureBox1.Refresh();
                pictureBox11.Refresh();
                base1.cardplayer++;
                if (base1.cardplayer == 5)
                    base1.cardplayer = 1;
                base1.cardpd++;
                if (base1.roundfc == 0)
                    base1.roundfc = base1.firstc[6];
                if (base1.tshown == 0 && base1.firstc[6] / 10 == base1.trumph[base1.highbider])
                    base1.aloowt[1] = 1;
                base1.onboard[1] = base1.firstc[6];
                base1.onhandc[base1.firstc[6] / 10, base1.firstc[6] % 10] = 0;
                base1.number_of_card[base1.firstc[6] / 10]--;
                base1.firstc[6] = 0;
                disablepb();
                start();
                return;
            }
            // pictureBox2.Image = Image.FromFile(@pa);
        }

        

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (base1.firstc[7] != 0 && ((base1.roundfirst == 1 &&base1.seventhcard==0)|| validofuser(base1.firstc[7])))
            {
                pictureBox1.Image = pictureBox12.Image;
            pictureBox12.Image = null;
            pictureBox1.Refresh();
            pictureBox12.Refresh();
            base1.cardplayer++;
            if (base1.cardplayer == 5)
                base1.cardplayer = 1;
            base1.cardpd++;
            if (base1.roundfc == 0)
                base1.roundfc = base1.firstc[7];
            if (base1.tshown == 0 && base1.firstc[7] / 10 == base1.trumph[base1.highbider])
                base1.aloowt[1] = 1;
            base1.onboard[1] = base1.firstc[7];
            base1.onhandc[base1.firstc[7] / 10, base1.firstc[7] % 10] = 0;
            base1.number_of_card[base1.firstc[7] / 10]--;
            base1.firstc[7] = 0;

           // pictureBox12.Visible = false;
            disablepb();
            //pictureBox12.Update();
            start();
            return;
        }

        }
        public void del()
        { }

        private void button8_Click(object sender, EventArgs e)
        {
            if (base1.tshown != 1)
            {
                System.Reflection.Assembly thisExe;
                thisExe = System.Reflection.Assembly.GetExecutingAssembly();
                int ok = 0;                         //ok==1 means can't see
                int runc = base1.onboard[base1.roundfirst];
                if (base1.roundfirst == 1)
                    ok = 1;
                else
                {
                    for (int i = 0; i <= 7; i++)        //running ache kina
                    {
                        if (base1.firstc[i] / 10 == runc / 10 && runc != 0)
                        {
                            ok++;
                        if (base1.firstc[i] == base1.seventhcard && base1.seventhcard != 0) //eta seventh card hole hate nae.
                            ok--;
                        }
                    }

                    if (ok >= 1)
                        ok = 1;
                    else if (ok <= 0)
                        ok = 0;
                }

                

                if (ok == 0)
                {
                    string path = "_29_card.res.";
                    string pa = "";
                    pa += path + base1.trumph[base1.highbider].ToString() + ".png";

                    base1.tshown = 1;
                    file =
                    thisExe.GetManifestResourceStream(pa);
                    pictureBox13.Image = Image.FromStream(file);

                    button8.Enabled = false;
                    this.Refresh();

                    //check marriage
                    int king = 0, qu = 0, trmm = base1.trumph[base1.highbider];
                    int[] mr = new int[8];
                    for (int j = 1; j <= 4; j++)
                    {
                        king = 0;
                        if (j == 1)
                            Array.Copy(base1.firstc, mr, base1.firstc.Length);
                        if (j == 2)
                            Array.Copy(base1.secondc, mr, base1.secondc.Length);
                        if (j == 3)
                            Array.Copy(base1.thirdc, mr, base1.thirdc.Length);
                        if (j == 4)
                            Array.Copy(base1.forthc, mr, base1.forthc.Length);
                        for (int i = 0; i <= 7; i++)
                        {
                            if (mr[i] / 10 == trmm && (mr[i] % 10 == 3 || mr[i] % 10 == 4))
                                king++;

                        }

                        if (king == 2)
                        {
                            string mar = "";
                            if (j == 1)
                                mar += label1.Text;
                            if (j == 2)
                                mar += label2.Text;
                            if (j == 3)
                                mar += label3.Text;
                            if (j == 4)
                                mar += label4.Text;

                            if (base1.highbider % 2 == j % 2)//same team
                            {
                                if (base1.call[base1.highbider] >= 18)
                                {
                                    base1.call[base1.highbider] -= 4;
                                    if (base1.call[base1.highbider] <= 15)
                                        base1.call[base1.highbider] = 16;

                                    MessageBox.Show(mar + " got Marriage Card! Call reduces to " + Convert.ToString(base1.call[base1.highbider]));
                                }
                            }
                            else if (base1.highbider % 2 != j % 2)
                            {
                                int mrr = base1.call[base1.highbider] += 4;

                                MessageBox.Show(mar + " got Marriage Card! Call increases to " + Convert.ToString(mrr));

                            }
                        }

                    }

                    //


                }
                else
                    MessageBox.Show("You can't see the trump now!");
            }
            else
            {
                button8.Enabled = false;
            }

        }


        

        public void print()
        {
            //Array.Sort(base1.secondc); Array.Sort(base1.thirdc); Array.Sort(base1.forthc);
            string op = "";
            
            for (int t = 2; t <= 4; t++)
            {
                op = "";
                for (int crd = 0; crd <= 7; crd++)
                {
                    if (t == 2)
                    {
                        int cardt = base1.secondc[crd] / 10;
                        int cadrp = base1.secondc[crd] % 10;
                        if (cardt == 1)
                            op += "Heart ";
                        if (cardt == 2)
                            op += "Club ";
                        if (cardt == 3)
                            op += "Dice ";
                        if (cardt == 4)
                            op += "Spade ";

                        if (cadrp == 1)
                            op += "7\n";
                        if (cadrp == 2)
                            op += "8\n";
                        if (cadrp == 3)
                            op += "Queen\n";
                        if (cadrp == 4)
                            op += "King\n";
                        if (cadrp == 5)
                            op += "10\n";
                        if (cadrp == 6)
                            op += "A\n";
                        if (cadrp == 7)
                            op += "9\n";
                        if (cadrp == 8)
                            op += "jack\n";
                        richTextBox1.Text = op;
                    }
                    if (t == 3)
                    {
                        int cardt = base1.thirdc[crd] / 10;
                        int cadrp = base1.thirdc[crd] % 10;
                        if (cardt == 1)
                            op += "Heart ";
                        if (cardt == 2)
                            op += "Club ";
                        if (cardt == 3)
                            op += "Dice ";
                        if (cardt == 4)
                            op += "Spade ";

                        if (cadrp == 1)
                            op += "7\n";
                        if (cadrp == 2)
                            op += "8\n";
                        if (cadrp == 3)
                            op += "Queen\n";
                        if (cadrp == 4)
                            op += "King\n";
                        if (cadrp == 5)
                            op += "10\n";
                        if (cadrp == 6)
                            op += "A\n";
                        if (cadrp == 7)
                            op += "9\n";
                        if (cadrp == 8)
                            op += "jack\n";
                        richTextBox2.Text = op;
                    }
                    if (t == 4)
                    {
                        int cardt = base1.forthc[crd] / 10;
                        int cadrp = base1.forthc[crd] % 10;
                        if (cardt == 1)
                            op += "Heart ";
                        if (cardt == 2)
                            op += "Club ";
                        if (cardt == 3)
                            op += "Dice ";
                        if (cardt == 4)
                            op += "Spade ";

                        if (cadrp == 1)
                            op += "7\n";
                        if (cadrp == 2)
                            op += "8\n";
                        if (cadrp == 3)
                            op += "Queen\n";
                        if (cadrp == 4)
                            op += "King\n";
                        if (cadrp == 5)
                            op += "10\n";
                        if (cadrp == 6)
                            op += "A\n";
                        if (cadrp == 7)
                            op += "9\n";
                        if (cadrp == 8)
                            op += "jack\n";
                        richTextBox3.Text = op;
                    }

                }

            }








            this.Refresh();
        
        }
        


        public void showtrum()
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            string ppll = "";
            if (base1.cardplayer == 1)
                ppll = saved.one;
            if (base1.cardplayer == 2)
                ppll = saved.two;
            if (base1.cardplayer == 3)
                ppll = saved.three;
            if (base1.cardplayer == 4)
                ppll = saved.four;


            MessageBox.Show(ppll+" wants to see the Trump card.");
           // button8.Enabled = false;

            string path = "_29_card.res.";
            string pa = "";
            pa += path  + base1.trumph[base1.highbider].ToString() + ".png";

            base1.tshown = 1;
            file =
                thisExe.GetManifestResourceStream(pa);
            pictureBox13.Image = Image.FromStream(file);
            //pictureBox13.Invalidate();
            //pictureBox13.Update();
            pictureBox13.Refresh();
           
           button8.Enabled = false;
           button8.Refresh();
           this.Refresh();

            //check marriage
            int king=0,qu=0,trmm=base1.trumph[base1.highbider];
            int[] mr=new int[8];
           for (int j = 1; j <= 4; j++)
           {
               king = 0;
               if(j==1)
                   Array.Copy(base1.firstc,mr,base1.firstc.Length);
               if(j==2)
                   Array.Copy(base1.secondc,mr,base1.secondc.Length);
               if(j==3)
                   Array.Copy(base1.thirdc,mr,base1.thirdc.Length);
               if(j==4)
                   Array.Copy(base1.forthc,mr,base1.forthc.Length);
               for (int i = 0; i <= 7; i++)
               {
                   if (mr[i] / 10 == trmm && (mr[i] % 10 == 3 || mr[i] % 10 == 4))
                       king++;
               
               }

               if (king == 2)
               {
                   string mar = "";
                   if (j == 1)
                       mar += label1.Text;
                   if (j == 2)
                       mar += label2.Text;
                   if (j == 3)
                       mar += label3.Text;
                   if (j == 4)
                       mar += label4.Text;

                   if (base1.highbider % 2 == j%2)//same team
                   {
                       if (base1.call[base1.highbider] >= 18)
                       {
                           base1.call[base1.highbider] -= 4;
                           if (base1.call[base1.highbider] <= 15)
                               base1.call[base1.highbider] = 16;

                           MessageBox.Show(mar + " got Marriage Card! Call reduces to " + Convert.ToString(base1.call[base1.highbider]));
                       }
                   
                   }
                   else if(base1.highbider % 2 != j%2)
                   {
                       base1.call[base1.highbider] += 4;

                       MessageBox.Show(mar + " got Marriage Card! Call increases to " + Convert.ToString(base1.call[base1.highbider]));
                   
                   }
               }
           
           }

           //


            

           return;
           
        }

        public void enablepb()
        {
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            return;
        
        }
        public void disablepb()
        { 
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;

            pictureBox5.Visible = true;
            //this.Refresh();
           // Refresh();
            return;
        
        }

        public void updatepointtable()
        {
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();

            this.Refresh();

            int hb = base1.highbider;
            int clll = base1.call[hb];
            int calwas;
            if (hb == 1 || hb == 3)
            {
                if (base1.userpoint >= clll)
                    uspo++;
                else
                    uspo--;
            
            }
            if (hb == 2 || hb == 4)
            {
                if (base1.pcpoint >= clll)
                    pcpo++;
                else
                    pcpo--;
            }
            string ppath = "_29_card.res.";
            string upd="";
            string papp = "";
            if (base1.tshown == 1||base1.seventhcard!=0)
            {
                if (uspo == 0)
                    papp = "tt.png";
                if (uspo == 1)
                    papp = "mp1.png";
                if (uspo == 2)
                    papp = "mp2.png";
                if (uspo == 3)
                    papp = "mp3.png";
                if (uspo == 4)
                    papp = "mp4.png";
                if (uspo == 4)
                    papp = "mp4.png";
                if (uspo == 5)
                    papp = "mp5.png";
                if (uspo == 6)
                    papp = "mp6.png";
                if (uspo == -1)
                    papp = "mm1.png";
                if (uspo == -2)
                    papp = "mm2.png";
                if (uspo == -3)
                    papp = "mm3.png";
                if (uspo == -4)
                    papp = "mm4.png";
                if (uspo == -5)
                    papp = "mm5.png";
                if (uspo == -6)
                    papp = "mm6.png";
                upd += ppath + papp;
                
                file =
                thisExe.GetManifestResourceStream(upd);
                pictureBox15.Image = Image.FromStream(file);
                if (uspo != 0)
                    pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
                else
                    pictureBox15.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox15.Refresh();

                if (pcpo == 0)
                    papp = "tt.png";
                if (pcpo == 1)
                    papp = "opp1.png";
                if (pcpo == 2)
                    papp = "opp2.png";
                if (pcpo == 3)
                    papp = "opp3.png";
                if (pcpo == 4)
                    papp = "opp4.png";
                if (pcpo == 5)
                    papp = "opp5.png";
                if (pcpo == 6)
                    papp = "opp6.png";
                if (pcpo == -1)
                    papp = "opm1.png";
                if (pcpo == -2)
                    papp = "opm2.png";
                if (pcpo == -3)
                    papp = "opm3.png";
                if (pcpo == -4)
                    papp = "opm4.png";
                if (pcpo == -5)
                    papp = "opm5.png";
                if (pcpo == -6)
                    papp = "opm6.png";
                upd = "";
                upd += ppath + papp;
                file =
                thisExe.GetManifestResourceStream(upd);
                pictureBox14.Image = Image.FromStream(file);
                if (pcpo != 0)
                    pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
                else
                    pictureBox14.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox14.Refresh();

                int winn = 0;

                if (uspo == 6)///
                {
                    winp();
                    MessageBox.Show("You Won!!! Congratulations!!!!");
                    winn = 1;
                }
                if(uspo==-6)
                {
                    losep();
                    MessageBox.Show("You Lose!!! ");
                    winn = 1;
                }
                if(pcpo==6)
                {
                    losep();
                    MessageBox.Show("You Lose!!!");
                    winn=1;
                }
                if (pcpo == -6)
                {
                    winp();
                    MessageBox.Show("You Won!!! Congratulations!!!!");
                    winn = 1;
                }

                if (winn==1)
                { 
                    ///////////////////RESTART GAME

                    
                    var rett = MessageBox.Show("Do you want to play again??", "29 card game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rett == System.Windows.Forms.DialogResult.Yes)
                        reset();
                    else
                    {
                        //this.Close();
                        Application.Exit();


                    }
                    
                
                }

            }
            else
            {
                MessageBox.Show("Trump Card is not Shown!!! The points of This Round are not Countable!!!");
            }

            

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }


        public bool validofuser(int crdd)
        {
            int havcrd = 0, inv = 0;
            if (base1.roundfirst != 1)
            {
                for (int i = 0; i <= 7; i++)
                    if (base1.firstc[i] / 10 == base1.roundfc / 10)
                    {havcrd++;

                    if (base1.seventhcard == base1.firstc[i] && base1.tshown == 0)
                        havcrd--;
                    }


            }

            if (havcrd >= 1) havcrd = 1;
            else if (havcrd <= 0) havcrd = 0;

            /*
            if (havcrd == 1 && crdd / 10 != base1.roundfc / 10&&thisislastseven!=1) 
                inv = 1;                            //not valid card ache charci na.

            if (thisislastseven == 1 && trm==0&&base1.tshown==1&&havcrd==1&&crdd/10!=base1.trumph[base1.highbider])  //seventh card single thakle trm dekhle onno card valid na
                inv = 1;*/
            if (havcrd == 1 && crdd / 10 != base1.roundfc / 10)
                inv = 1;                            //not valid card ache charci na.

            if (trm == 0 && base1.tshown == 1 && havcrd == 1 && crdd / 10 != base1.trumph[base1.highbider])  //seventh card single thakle trm dekhle onno card valid na
                inv = 1;


            int havtrm = 0;
            for (int i = 0; i <= 7; i++)        //koyta trm ache
            {
                if (base1.firstc[i] != 0 && base1.firstc[i] / 10 == base1.trumph[base1.highbider])
                    havtrm++;

            }
            if (base1.tshown == 1 && trm == 0 && havcrd == 0 && crdd / 10 != base1.trumph[base1.highbider])      //running card nae, trm dekhci kintu trm dicchi na
            {
                inv = 1;
                if (havtrm == 0)       //trm dicchi na karon trm nae
                    inv = 0;
            }

            if (base1.tshown == 0 && crdd == base1.seventhcard)     //seven a trum select korci& kintu show na koei khelte chacchi.
            {
                inv = 1;
                MessageBox.Show("This is your seventh card! Can't play this card before showing that it is your trump suit\n or you can place another card.\n**Whether Trump is shown or not, game point will be counted.");
            }
            if (inv == 1)
            {
                return false;
                MessageBox.Show("Invalid Card!");

            }
            else
                return true;
        }

        

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgr.sel = 0;
            backgr f2 = new backgr();
            f2.ShowDialog();

            if(backgr.sel==0)
            {
                /*System.Reflection.Assembly thisExe;
                thisExe = System.Reflection.Assembly.GetExecutingAssembly();
                bcfile =
                thisExe.GetManifestResourceStream("_29_card.back.gr.jpg");
                this.BackgroundImage = Image.FromStream(bcfile);
            */
               
            }
            else //one image has been selected sel==1
            {
                        this.BackgroundImage = Image.FromStream(fileb);
                    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                
                    String localll = Environment.CurrentDirectory;

                    



                    string ppathi = localll + "\\29_card.txt";
                    
                    try
                    {
                        TextWriter twe = new StreamWriter(@ppathi);
                        twe.WriteLine(saved.one);
                        twe.WriteLine(saved.two);
                        twe.WriteLine(saved.three);
                        twe.WriteLine(saved.four);
                        twe.WriteLine(base1.backimg);
                        twe.Close();

                        saved.backg = "";
                        saved.backg += base1.backimg;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    chklebc();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }
        
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // WM_CLOSE
            {
                // Process the form closing. Call the base method if required,
                // and return from the function if not.
                // For example:
                var ret = MessageBox.Show("Do you really want to Close 29-card Game??", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == System.Windows.Forms.DialogResult.No)
                    return;
                else
                {
                    //this.Close();
                    Environment.Exit(1);
                    Application.Exit();


                }
            }
            base.WndProc(ref m);
        }
         

       
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close();
            this.Dispose();
            this.Close();
            base1 bss = new base1();
            Form1 fu = new Form1();
            label5.Text = "Get New Deal!!";
            fu.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help hl = new help();
            hl.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.ShowDialog();
        }

        private void startSoundPlayer()
        {
            
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            music =
                thisExe.GetManifestResourceStream("_29_card.back.sf-card.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(music);
            player.Play();
        }

        private void place_card()
        {

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            music =
                thisExe.GetManifestResourceStream("_29_card.back.nv.wav");
            System.Media.SoundPlayer playerc = new System.Media.SoundPlayer(music);
            playerc.Play();
        }
        private void winp()
        {

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            music =
                thisExe.GetManifestResourceStream("_29_card.back.win.wav");
            System.Media.SoundPlayer playera = new System.Media.SoundPlayer(music);
            playera.Play();
        }
        private void losep()
        {

            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            music =
                thisExe.GetManifestResourceStream("_29_card.back.lose.wav");
            System.Media.SoundPlayer playerb = new System.Media.SoundPlayer(music);
            playerb.Play();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void setPlayersNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setname snm = new setname();
            snm.ShowDialog();
            label1.Text = saved.one;
            label2.Text = saved.two;
            label3.Text = saved.three;
            label4.Text = saved.four;
        }
        public void reset()
        {
           /* Form1 fmm = new Form1();
            this.Dispose();
            fmm.Show();
        */
           /* Form1.ActiveForm.Dispose();
            Form1 sd = new Form1();
            sd.Show();
            */
             path = "";
         card = 1;
            cal=0;
        
        
         callpoint = "";
         mytr = "";
        //for set call
        
         fs = 0;
         se = 0; th = 0; fo = 0;
        

         uspo = 0;
         pcpo = 0;
        //
       
            
            System.Reflection.Assembly thisExe;
            thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            file =
                thisExe.GetManifestResourceStream(saved.backg);
            this.BackgroundImage = Image.FromStream(file);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            

            file =
                thisExe.GetManifestResourceStream(ffile+"tt.png");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;

            pictureBox13.Image = Image.FromStream(file);
            pictureBox14.Image = Image.FromStream(file);
            pictureBox14.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox15.Image = Image.FromStream(file);
            pictureBox15.SizeMode = PictureBoxSizeMode.CenterImage;
            button2.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled=false;
                disablepb();
                label5.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label18.Text = "";

                //richTextBox1.Visible = false;
               // richTextBox2.Visible = false;
               // richTextBox3.Visible = false;

                label12.Text = "";
                label13.Text = "";
                label20.Text = "User";
                label21.Text = "Pc";

                getcard.Enabled = true;
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;


                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;


                button2.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;

                label1.Text = saved.one;
                label2.Text = saved.two;
                label3.Text = saved.three;
                label4.Text = saved.four;
                 base1.trmsel = 0;
        base1.forthplayer=0;
       

        base1.seventhcard = 0;
        
       base1.bidding = 0;

        
        base1.firstcaller=0;
            base1.passes = 0;
            base1.time = 0;
            base1.cardplayer=0;
            base1.cardpd=0;
       
        
        base1.tshown = 0;
            base1.tselected=0;
            base1.roundfirst=0;
            base1.roundfc=0;



        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                stc.Abort();
                strt.Abort();
            }
            catch { }

            
            try
            {
                Form fc = Application.OpenForms["stcall"];      //if stcall is opened then close it

                if (fc != null)
                    fc.Close(); 
                
            }
            catch
            { }
            reset();
        }

        public void chklebc()
        {

            label5.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;

            //normal
            label5.ForeColor = Color.Navy;
            label8.ForeColor = Color.SpringGreen;
            label3.ForeColor = Color.SpringGreen;
            label10.ForeColor = Color.MediumTurquoise;
            label11.ForeColor = Color.MediumTurquoise;
            label12.ForeColor = Color.MediumTurquoise;
            label13.ForeColor = Color.MediumTurquoise;
            label19.ForeColor = Color.Red;
            label20.ForeColor = Color.Lime;
            label2.ForeColor = Color.SpringGreen;
            label4.ForeColor = Color.SpringGreen;
            label7.ForeColor = Color.Cyan;
            label8.ForeColor = Color.Cyan;
            label9.ForeColor = Color.Cyan;
            label1.ForeColor = Color.Turquoise;
            label18.ForeColor = Color.Maroon;
            label21.ForeColor = Color.SpringGreen;
            //
            if (saved.backg.Contains("w2.jpg"))
            {
                label5.ForeColor = Color.Cyan;
            }
            else if (saved.backg.Contains("c1.jpg"))
            {
                label5.ForeColor = Color.Cyan;
            }
            else if (saved.backg.Contains("col.jpg"))
            {
                label5.ForeColor = Color.Cyan;
            }
            else if (saved.backg.Contains("fn.jpg"))
            {
                label5.ForeColor = Color.Cyan;
            }
            else if (saved.backg.Contains("gl.jpg"))
            {
                label5.ForeColor = Color.Cyan;
            }
            else if (saved.backg.Contains("wo1.jpg"))
            {
                label5.ForeColor = Color.Cyan;
            }
            else if (saved.backg.Contains("mt.jpg"))
            {
                //label5.ForeColor = Color.Cyan;
                label1.ForeColor = Color.Navy;
                label2.ForeColor = Color.Navy;
                label3.ForeColor = Color.Navy;
                label4.ForeColor = Color.Navy;
                label5.ForeColor = Color.Navy;
                label6.ForeColor = Color.Navy;
                label7.ForeColor = Color.Navy;
                label8.ForeColor = Color.Navy;
                label9.ForeColor = Color.Navy;
                label10.ForeColor = Color.DarkGreen;
                label11.ForeColor = Color.Crimson;
                label12.ForeColor = Color.Navy;
                label13.ForeColor = Color.Navy;
                //label14.ForeColor = Color.Navy;
                //label15.ForeColor = Color.Navy;
                //label16.ForeColor = Color.Navy;
                //label17.ForeColor = Color.Navy;
                label18.ForeColor = Color.Navy;
                label19.ForeColor = Color.Navy;
                label20.ForeColor = Color.DarkMagenta;
                label21.ForeColor = Color.DarkMagenta;


            }
            else if (saved.backg.Contains("co.jpg"))
            {
                label3.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
                label5.BackColor = Color.SteelBlue;
                label10.BackColor = Color.SteelBlue;
                label11.BackColor = Color.SteelBlue;
                label12.BackColor = Color.SteelBlue;
                label13.BackColor = Color.SteelBlue;
                label5.ForeColor = Color.Cyan;
                label10.ForeColor = Color.Cyan;
                label11.ForeColor = Color.Cyan;
                label12.ForeColor = Color.Cyan;
                label13.ForeColor = Color.Cyan;
            }
            else
            {
                label5.ForeColor = Color.Navy;
                label8.ForeColor = Color.SpringGreen;
                label3.ForeColor = Color.SpringGreen;
                label10.ForeColor = Color.MediumTurquoise;
                label11.ForeColor = Color.MediumTurquoise;
                label12.ForeColor = Color.MediumTurquoise;
                label13.ForeColor = Color.MediumTurquoise;
                label19.ForeColor = Color.Red;
                label20.ForeColor = Color.Lime;
                label2.ForeColor = Color.SpringGreen;
                label4.ForeColor = Color.SpringGreen;
                label7.ForeColor = Color.Cyan;
                label8.ForeColor = Color.Cyan;
                label9.ForeColor = Color.Cyan;
                label1.ForeColor = Color.Turquoise;
                label18.ForeColor = Color.Maroon;
                label21.ForeColor = Color.SpringGreen;
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.Font = new Font("Arial narrow", 7, FontStyle.Bold);
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.Font = new Font("Arial narrow", 6, FontStyle.Regular);
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void dispose()
        { 
            ///picturebox clear 1
            if (pictureBox1.BackgroundImage != null)
	            {
	                pictureBox1.BackgroundImage.Dispose();
	            }
            if (pictureBox1.Image != null)
	            {
	            pictureBox1.Image.Dispose();
	            }
            ///picturebox clear 2
            if (pictureBox2.BackgroundImage != null)
            {
                pictureBox2.BackgroundImage.Dispose();
            }
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
            }

            ///picturebox clear 3
            if (pictureBox3.BackgroundImage != null)
            {
                pictureBox3.BackgroundImage.Dispose();
            }
            if (pictureBox3.Image != null)
            {
                pictureBox3.Image.Dispose();
            }

            ///picturebox clear 4
            if (pictureBox4.BackgroundImage != null)
            {
                pictureBox4.BackgroundImage.Dispose();
            }
            if (pictureBox4.Image != null)
            {
                pictureBox4.Image.Dispose();
            }

            ///picturebox clear 5
            if (pictureBox5.BackgroundImage != null)
            {
                pictureBox5.BackgroundImage.Dispose();
            }
            if (pictureBox5.Image != null)
            {
                pictureBox5.Image.Dispose();
            }

            ///picturebox clear 6
            if (pictureBox6.BackgroundImage != null)
            {
                pictureBox6.BackgroundImage.Dispose();
            }
            if (pictureBox6.Image != null)
            {
                pictureBox6.Image.Dispose();
            }

            ///picturebox clear 7
            if (pictureBox7.BackgroundImage != null)
            {
                pictureBox7.BackgroundImage.Dispose();
            }
            if (pictureBox7.Image != null)
            {
                pictureBox7.Image.Dispose();
            }

            ///picturebox clear 8
            if (pictureBox8.BackgroundImage != null)
            {
                pictureBox8.BackgroundImage.Dispose();
            }
            if (pictureBox8.Image != null)
            {
                pictureBox8.Image.Dispose();
            }

            ///picturebox clear 9
            if (pictureBox9.BackgroundImage != null)
            {
                pictureBox9.BackgroundImage.Dispose();
            }
            if (pictureBox9.Image != null)
            {
                pictureBox9.Image.Dispose();
            }

            ///picturebox clear 10
            if (pictureBox10.BackgroundImage != null)
            {
                pictureBox10.BackgroundImage.Dispose();
            }
            if (pictureBox10.Image != null)
            {
                pictureBox10.Image.Dispose();
            }

            ///picturebox clear 11
            if (pictureBox11.BackgroundImage != null)
            {
                pictureBox11.BackgroundImage.Dispose();
            }
            if (pictureBox11.Image != null)
            {
                pictureBox11.Image.Dispose();
            }

            ///picturebox clear 12
            if (pictureBox12.BackgroundImage != null)
            {
                pictureBox12.BackgroundImage.Dispose();
            }
            if (pictureBox12.Image != null)
            {
                pictureBox12.Image.Dispose();
            }
            
        
        
        }
    }
}



