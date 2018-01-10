using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_card
{
    class AI : Form1
    {

        public AI()
        {


        }

        public static int selectedcardpos;
        int nowplayer = 0;
        int have = 0, maxp = 0, minp = 99, maxtr = 0, mintr = 99, maxnor = 0, minnor = 99, howmanyrun = 0, howmanytrum = 0,crysiscard=0;
        int whogets = 0, gett = 0, getrun = 0, trump = 0, cardp = 0, pointonboard = 0;
        int trumpcard = base1.trumph[base1.highbider];
        int playthis = 0;
        int[] temp = new int[8];
        int hrt = 0, clb = 0, spd = 0, dic = 0, trum = 0;
        int trumleft = 0;
        int running = base1.roundfc / 10;  //which card is running
        int mate, opmate,opmate2;
        int nonvalidoptioncard = 0;
        int ii = 0;
        /// <summary>
        /// round ke pacche and save all info
        /// </summary>
        public void faltu()  //calculate who is getting this round(4-card) +acknoledging users seventh card crysis
        {

            int running = base1.roundfc / 10;
            int anyt = 0, gret = 0, maxtr = 0, pointonboard = 0;

            trumpcard = base1.trumph[base1.highbider];


            for (int i = 1; i <= 4; i++)
            {
                if (base1.onboard[i] != running)
                    base1.havet[i, running] = -1; //don't have this card
            }



            if (base1.tshown == 1 && trumpcard != running)
            {
                for (int i = 1; i <= 4; i++)
                {
                    if (base1.onboard[i] / 10 == base1.trumph[base1.highbider] && base1.aloowt[i] == 0 && base1.onboard[i] != 0)
                    {
                        anyt = 1;
                        if (base1.onboard[i] > gret)
                        {
                            gret = base1.onboard[i];
                            maxtr = i;

                            base1.trumpedby[running, i] = 1;  //who trumps on what
                        }

                    }

                }

            }
            ///

            foundcrysis();


            ////


            ///lead card board correction
            for (int i = 1; i <= 4; i++)
            {
                int ccc = base1.onboard[i];
                for (int j = 0; j <= 7; j++)
                {
                    if (base1.cardlead[ccc / 10, j] == ccc)
                        base1.cardlead[ccc / 10, j] = 0;
                }


            }



            ///

            if (anyt == 1)
            {
                base1.roundfirst = maxtr;
            }
            else
            {
                int maxi = 0, gt = 0;
                for (int j = 1; j <= 4; j++)
                {
                    if (base1.onboard[j] / 10 == running && base1.onboard[j] != 0)
                    {
                        if (gt < base1.onboard[j])
                        {
                            gt = base1.onboard[j];
                            base1.roundfirst = j;
                        }
                    }

                }

            }

            //////////////////////memorizing what type has how many card left

            for (int h = 1; h <= 4; h++)
            {
                int typ, rank;
                typ = base1.onboard[h] / 10;
                rank = base1.onboard[h] % 10;

                base1.onhandc[typ, rank] = 0;
               // base1.number_of_card[typ]--;
                base1.tot_po[typ] -= base1.point[rank];

                if (base1.onboard[h] % 10 == 8)
                    pointonboard += 3;
                else if (base1.onboard[h] % 10 == 7)
                    pointonboard += 2;
                else if (base1.onboard[h] % 10 == 6)
                    pointonboard += 1;
                else if (base1.onboard[h] % 10 == 5)
                    pointonboard += 1;
            }


            //////////////////

            if (base1.roundfirst % 2 == 0)
                base1.pcpoint += pointonboard;
            else
                base1.userpoint += pointonboard;

            this.Refresh();

            if (base1.seventhcard != 0)
            {
                int num = 0;
                for (int i = 0; i <= 7; i++)
                    if (base1.firstc[i] != 0 && base1.firstc[i] / 10 == base1.seventhcard / 10)
                        num++;

                if (num == 1)       //seventh card trump last card remaining
                    Form1.thisislastseven = 1;
            }
            
        }

        public void foundcrysis()  //previous khelay k ki dilo, kar kache card nai?
        {
            /////////////find ager round a keu crysis a chilo kina, means next er khelay trum korte pare

            int frst = base1.roundfirst, rnd = 1, frscard = base1.roundfc, alrdtrum = 0, runningtypmaxp = 0, trumper = 0, maxtrn = 0;
            int[] plc = new int[5];
            int[] real = new int[5];
            int runningmaxp = 0, runningget = 0;
            while (rnd <= 4)  //saving in plc which hand placed what
            {
                real[rnd] = frst;  //saves really 1 bolte kake bojhay...
                base1.previousround[frscard / 10, frst] = base1.onboard[frst]; //running khelay k ki dicche
                plc[rnd++] = base1.onboard[frst];
                frst++;
                if (frst == 5) frst = 1;


            }

            for (int i = 2; i <= 4; i++) //as computing crysis no need to calc about first hand
            {
                if (plc[i - 1] / 10 == trumpcard / 10 && base1.aloowt[real[i]] == 0)  //ager player trum dice kina ...if tokhono trum jana chilo na taile ki?
                {
                    alrdtrum = 1;
                    if (maxtrn < plc[i - 1])
                    {
                        maxtrn = plc[i - 1];
                        trumper = i - 1;
                    }

                }
                if (plc[i - 1] / 10 == frscard / 10)   //ager player ki khelche
                {
                    if (runningmaxp < plc[i - 1])
                    {
                        runningmaxp = plc[i - 1];
                        runningget = i - 1;
                    }

                }

                int getter = 0;
                if (plc[runningget] > plc[i] && runningget % 2 != i % 2)
                    getter = 1;   //oppnent pacche

                if (plc[i] / 10 == frscard / 10)    //running card er khela dice
                {
                    if (plc[i] % 10 >= 5 && ((trumper % 2 != i % 2)&&trumper!=0) || getter == 1) //age opnent trumper/getter thakleo point charte hoice
                    {

                        base1.everyonehave[frscard / 10, real[i]] = 0;

                    }
                    if (plc[i] % 10 >= 7 && ((trumper % 2 != i % 2)&&trumper!=0)|| getter == 1)
                        base1.everyonehave[frscard / 10, real[i]] = -1;     //next time will trum sure
                }

                if (frscard / 10 != plc[i] / 10)     //onno card diche so ar nae.
                    base1.everyonehave[frscard / 10, real[i]] = -1;




            }





        }


        /// <summary>
        /// AI thinking....
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public int pc(int who) //who means who is going to draw card
        {


            ///delete
           
            

            ///

            int uuu;
            nowplayer = who;
            if (base1.cardpd <= 31)
            {
                trumpcard = base1.trumph[base1.highbider];
                playthis = 0;
                // int[] temp = new int[8];

                running = base1.roundfc / 10;  //which card is running

                if (who == 2)
                    Array.Copy(base1.secondc, temp, 8);
                else if (who == 3)
                    Array.Copy(base1.thirdc, temp, 8);
                else if (who == 4)
                    Array.Copy(base1.forthc, temp, 8);

                if (who == 3)
                    uuu = 0;
                
                aihaveminmax();
                whogetthis();
                whichcardhowmany();

                sortar();               ///kon card er leader k?   sorted obosthay ache      

                mate = who + 2;
                if (mate == 5) mate = 1;
                else if (mate == 6) mate = 2;
                opmate = mate - 1;
                if (opmate == 0) opmate = 4;

                opmate2=mate+1;
                if(opmate2==5)
                    opmate2=1;
                ///

                int forthp = 0;
                ii = 0;
                for (int i = 1; i <= 4; i++)
                    if (base1.onboard[i] != 0) ii++;
                if (ii == 3)
                    forthp = who;

                ////////////////
                //////////////////////////////////////////////////////////////////////////////////
                //////////////
                if (forthp != 0)//4th player
                {
                    int leadc = base1.cardlead[running, 0];  //running =which type card is runnong

                    int ihavelead = 0;
                    for (int i = 0; i <= 7; i++)
                        if (temp[i] == leadc)
                            ihavelead = 1;

                    int largnow = 0, wow = 0;
                    if (gett != 0)
                        largnow = base1.onboard[gett];
                    if (gett == 0)
                        largnow = base1.onboard[getrun];
                    if (gett == mate) wow = 1;
                    if (gett == 0 && getrun == mate && getrun != 0) wow = 1;

                    if (have == 1)
                    {
                        if (wow == 1 || (maxp > largnow && gett == 0))        //may mate pacche ekhon porjonto by trump
                            playthis = maxp;
                        else
                            playthis = minp;

                        if (running == trumpcard && base1.tshown == 1) ///trumph card er khela 
                        {
                            if (ihavelead == 1 && gett % 2 == who % 2)       //amar lead card ache and my mate pachhe
                                playthis = minp;
                            else if (ihavelead == 1 && gett % 2 != who % 2)      //amar lead ache but mate pacche na
                                playthis = maxp;
                        }

                        ///*****tin card er cheye beshi point thakle ki korbe?

                        if (playthis == 0 || playthis == 99)
                        {
                            if (getrun % 2 == who % 2&&getrun!=0)        //may mate pacche ekhon porjonto by running
                                playthis = maxp;
                            else
                                playthis = minp;

                        }
                    }
                    else //idon't have this type card
                    {
                        if (((gett != 0 && gett == mate) || (getrun != 0 && getrun == mate && gett == 0)) &&(maxnor/10!=base1.trumph[base1.highbider])) //mate pacche
                        {
                            playthis = maxnor;
                        }
                        else
                        {
                            int minf = 99, minp = 9;
                            mintr = 99; maxtr = 0; howmanytrum = 0;
                            int[] ihv = new int[5];
                            for (int i = 0; i <= 7; i++)
                            {
                                if (temp[i] / 10 == base1.trumph[base1.highbider])
                                {

                                    if (mintr > temp[i])
                                        mintr = temp[i];
                                    if (maxtr < temp[i])
                                        maxtr = temp[i];
                                    howmanytrum++; //how many trum do i have

                                }
                                ihv[temp[i] / 10]++;

                            }
                            int prevn = 0;
                            for (int i = 0; i <= 7; i++)
                            {
                                if (ihv[temp[i] / 10] >= prevn && temp[i] % 10 <= minp && temp[i] != 0 && temp[i] / 10 != base1.trumph[base1.highbider])//sobcheye beshi (trump chara) kon card ache er point chara ta save hove
                                { minp = temp[i] % 10; minf = temp[i]; prevn = ihv[temp[i] / 10]; }


                            }

                            int tp = 0;
                            for (int i = 1; i <= 4; i++)
                            {
                                if (base1.onboard[i] != 0&&base1.onboard[i]%10>=5)
                                    tp += base1.point[base1.onboard[i] % 10];       //total koto point field a
                            }

                            int pp;
                            if(base1.highbider%2==0)
                                pp=Form1.pcpo;
                            else
                                pp=Form1.uspo;

                            if (base1.tshown == 0)     //trum age show hoy ni
                            {
                                if (tp >= 2 || (base1.call[base1.highbider] - pp <= 3)||minf%10>=5)
                                {//decided to see trump
                                    Form1 fm = new Form1();
                                    fm.showtrum();
                                    this.Refresh();


                                    if (howmanytrum > 0)
                                    {
                                        if (howmanytrum <= 2 && maxtr % 10 == 7 && base1.cardlead[trumpcard, 0] % 10 == 8)
                                            playthis = maxtr;
                                        else
                                            playthis = mintr;
                                    }
                                    else
                                        playthis = minf;
                                }
                                else //decided not to see trump
                                {

                                    playthis = minf;
                                
                                }

                            }
                            else if (base1.tshown == 1)     //trum jani
                            {
                                if (gett != 0 && gett != mate)      //age trum hoyece point thakle plus over thakle over
                                {
                                    int lasttrum = base1.onboard[gett], mine = 0;
                                    for (int i = 0; i <= 7; i++) if (temp[i] != 0 && temp[i] / 10 == trumpcard && temp[i] > lasttrum && mine == 0) mine = temp[i];
                                    if (tp >= 2 && mine != 0)
                                        playthis = mine;

                                }
                                else if (tp >= 1 && gett == 0 && getrun != mate)    //point ache + mate pabe na place trm
                                    playthis = mintr;
                                if (playthis == 0 || playthis == 99)    //trum chilo na so kichu kora ne jehetu so place no valued card
                                {
                                    playthis = minf;
                                    if (minf % 10 > 4)
                                    {
                                        for (int i = 0; i <= 7; i++)
                                            if (temp[i] % 10 < minf % 10&&temp[i]!=0)
                                                minf = temp[i];
                                    
                                    }
                                    playthis = minf;
                                }


                            }



                        }
                    }
                    if (playthis == 0 || playthis == 99)
                    {
                        if ((getrun!=0&&getrun % 2 == who % 2) || (gett!=0&&gett % 2 == who % 2))
                            playthis = maxnor;
                        else
                            playthis = minnor;

                        if (playthis == 0 || playthis == 99)
                        {
                            int mxp = 0, mxc = 0, mnp = 99, mnc = 0;
                            for (int i = 0; i <= 7; i++)
                            {
                                if (temp[i] != 0 && temp[i] % 10 > mxp) { mxp = temp[i] % 10; mxc = temp[i]; }
                                if (temp[i] != 0 && temp[i] % 10 < mnp) { mnp = temp[i] % 10; mnc = temp[i]; }
                            }
                            if ((getrun!=0&&getrun % 2 == who % 2) || (gett!=0&&gett % 2 == who % 2))
                                playthis = mxc;
                            else
                                playthis = mnc;

                        }

                    }

                }
                else           //not forth player
                {
                    if (who != base1.roundfirst) ////......................draw card NOT as first AI
                    {
                        int leadc = base1.cardlead[running, 0];  //running =which type card is runnong

                        int ihavelead = 0;
                        for (int i = 0; i <= 7; i++)
                            if (temp[i] == leadc && leadc != 0)
                                ihavelead = 1;            //running card er lead amar kache kina

                        if (have == 1) // i have running type card
                        {
                            if (gett != 0)                                 //already trumph placed gett= who is going to have till now round by trum
                            {
                                if (gett % 2 == who % 2)        //may mate pacche ekhon porjonto by trump
                                    playthis = maxp;
                                else
                                    playthis = minp;

                                int secle = base1.cardlead[running, 1];

                                if (running == trumpcard) ///trumph card er khela 
                                {
                                    if (ihavelead == 1 && gett % 2 == who % 2)       //amar lead card ache and my mate pachhe
                                        playthis = minp;
                                    else if (ihavelead == 1 && gett % 2 != who % 2)      //amar lead ache but mate pacche na
                                        playthis = maxp;
                                    if (gett % 2 == who % 2)//mate pacche
                                    {
                                        if (base1.onboard[gett] == base1.cardlead[running, 0] && maxp == secle)
                                            playthis = minp;
                                    
                                    }
                                }

                            }
                            else                                           //have running type but trumph not placed yet
                            {
                                int matetrumpos = 0, optrumpos = 0, getnow = 0;

                                for (int i = 1; i <= 4; i++)
                                    if (base1.onboard[i] != 0 && base1.onboard[i] == leadc) getnow = i; //running card lead diye k pacche

                                int placedtrumph = 0, a, b, c, oktomax = 0;

                                int runleft = 0;
                                runleft = base1.number_of_card[running];     //running er koyta card mathe

                                for (int i = 0; i <= 7; i++)
                                { if (temp[i] / 10 == running)runleft--; }

                                if ((ihavelead == 1 || getnow == mate) && (runleft >= 5)) //lead card amar && (>=5 card onnoder kache ache)
                                    playthis = maxp;
                                if (base1.highbider == who && base1.trumph[who] == running && ihavelead == 1)  //lead amar,amar call and eta amar trum er khela
                                {
                                    int seclead = 0;
                                    for (int i = 0; i <= 7; i++)
                                        if (temp[i] == leadc - 1) seclead = 1;
                                    if (seclead == 1)
                                        playthis = minp;
                                }
                                if (base1.everyonehave[running,mate] == -1 && base1.onboard[mate] == 0) //nai je eta sure orthat trum korte pare
                                    matetrumpos = 2;

                                if (ihavelead == 1 && runleft < 4) //age khela hoice kintu lead amar
                                {
                                    if (base1.everyonehave[running,mate] == 0) //mathe er ei card nai
                                        matetrumpos = 1;
                                    if (base1.everyonehave[running,mate] == -1) //nai je eta sure orthat trum korte pare
                                        matetrumpos = 2;
                                    if (base1.everyonehave[base1.trumph[base1.highbider],opmate] == -1) //opnent trum korte parbe na
                                        optrumpos = 0;
                                    if (base1.tshown == 1 && base1.everyonehave[ base1.trumph[base1.highbider],mate] == 1 && matetrumpos == 2 && optrumpos == 0)
                                        playthis = maxp;     //mate trum korbe and op er nai trum
                                    else
                                        playthis = minp;


                                }

                                int frstcal = 0;
                                for (int i = 1; i <= 4; i++)
                                    if (base1.onhandc[running, i] == 1) frstcal++;

                                if ((frstcal == 4 && maxp % 10 == 8) || base1.onboard[mate] % 10 == 8||(runleft>=3&&maxp%10==8))//means aage er khela hoy ni, so jack thakle diye dao
                                    playthis = maxp;

                                if (ihavelead == 0 && matetrumpos == 2)//lead amar na kintu mate trum korbe sure(ei card nai)
                                    playthis = maxp;
                                if (playthis == 0 || playthis == 99)
                                    playthis = minp;

                                if(running==trumpcard&&ii==2&&base1.onboard[mate]!=base1.cardlead[trumpcard,0])
                                    playthis = minp;


                            }//running ache trum pore ni


                        }
                        else // idont'have running type card
                        {
                            if (base1.tshown == 1)//trump shown
                            {
                                if (base1.tshown == 1 && running == trumpcard)
                                    tyes();                                         //tramer khela and trum shown of course

                                if (running != trumpcard)                              //trum er khela na
                                {
                                    int enim=mate-1;
                                    if(enim==0)
                                        enim=4;
                                    //as thrd man jodi dekhi mate pacche, pabe then don't use trump
                                    if ((gett == mate && base1.everyonehave[trumpcard, enim] == -1 && gett != 0) || (getrun == mate && base1.onboard[mate] == base1.cardlead[base1.onboard[mate]/10,0] && getrun != 0 && gett == 0 && base1.everyonehave[running, enim] > 0) || (getrun == mate && getrun != 0 && gett == 0 && base1.everyonehave[running, enim] <= 0 && base1.everyonehave[trumpcard, enim] == -1))
                                    {
                                        if (maxnor / 10 != trumpcard)
                                            playthis = maxnor;
                                    }
                                    else
                                    TNS();
                                }

                            }
                            else//trump not shown
                            {
                                Form1 fm = new Form1();
                                fm.showtrum();             //show trump()
                                this.Refresh();

                                if (running == trumpcard && base1.onboard[mate] == leadc&&leadc!=0)
                                    playthis = maxnor;
                                if(playthis==0||playthis==99)
                                    TNS();
                                

                            }

                        }        //i don't have run 






                    }//drawing card not as first
                    else//drawing card as                  FIRST--->
                    {
                        int trmno = 0, minti = 99;

                        int[] cardt = new int[5];
                        Array.Clear(cardt, 0, cardt.Length);

                        if (base1.highbider == who)         //caller
                        {
                            int pl = 0,pl2=0;
                            int ldcc = base1.cardlead[trumpcard, 0];
                            int scdc = base1.cardlead[trumpcard, 1];
                            for (int i = 0; i <= 7; i++)
                            {
                                if (temp[i] != 0)
                                    cardt[temp[i] / 10]++;

                                if (temp[i] == ldcc && ldcc != 0)
                                    pl = temp[i];
                                if (temp[i] == scdc && scdc != 0)
                                    pl2 = temp[i];
                                if (temp[i] / 10 == trumpcard && temp[i] != 0)
                                {
                                    trmno++;
                                    if (temp[i] < minti)
                                        minti = temp[i];

                                }
                            }

                            if (pl == ldcc && pl2 == scdc)
                                playthis = scdc;
                            else if(pl2!=scdc&&pl==ldcc)
                                playthis = pl;


                            //check karo kache trump ache kina...
                            int tottrmp=0;
                            tottrmp = base1.number_of_card[trumpcard];
                            tottrmp -= trmno;



                            if ((trmno >=3&&playthis==0&&tottrmp>=1))                 //trump 3 er soman ba beshi thakle place it && onnoder 1 er beshi trm ache
                            {
                                playthis = pl;

                                if (playthis == 0 || playthis == 99)        //trum lead nae but >=3 trum ache so place mini trum
                                {
                                    playthis = minti;
                                }
                            }

                           
                            //jodi kon card er lead thake && <=2 card thake r first time hoy tyhen place it/single card

                            int singc=0;
                            for (int i = 0; i <= 7; i++)
                            {
                                if (temp[i] % 10 == 8 && temp[i] != 0 && cardt[temp[i] / 10] <= 2&&base1.number_of_card[temp[i]/10]>=5)
                                    playthis = temp[i];
                                
                                if(temp[i]%10<=5&&cardt[temp[i]/10]==1&&temp[i]!=0)
                                    singc = temp[i];
                            
                            }
                            if ((playthis == 0 || playthis == 99)&&trmno<=3&&singc%10<5)
                            {
                                playthis = singc;
                            
                            
                            }



                                //if op don't have trump let them play
                                if ((base1.everyonehave[trumpcard, opmate] == -1 && base1.everyonehave[trumpcard, opmate2] == -1) || tottrmp <= 0)
                                {
                                    playthis = minnor;

                                    if (tottrmp <= 0)   //karo trm nae ba ja ache amar kachei ache
                                    {
                                        int anld = 0;
                                        int lessriskc = 0, lerskplc = 9;
                                        for (int i = 1; i <= 4; i++)
                                        {
                                            if (base1.cardlead[i, 0] % 10 <= 6 && base1.cardlead[i, 0] != 0)
                                                lessriskc = i;
                                            for (int j = 0; j <= 7; j++)
                                            {
                                                if (base1.cardlead[i, 0] == temp[j] && temp[j] != 0)
                                                    playthis = temp[j];

                                                if (temp[j] / 10 == lessriskc && lerskplc % 10 > temp[j] % 10 && temp[j] != 0)
                                                    lerskplc = temp[j];
                                            }
                                        }



                                        if ((playthis == 0 || playthis == 99))//so amar kache r onno card er lead nae, so find such card which lead don't have 9 or j as lead
                                        {


                                            playthis = lerskplc;
                                        }



                                    }
                                    if (playthis == 0 || playthis == 99)
                                        playthis = minnor;
                                }


                            if (playthis == 0 || playthis == 99)
                                two();


                                  
                            
                                if (playthis == 0 || playthis == 99)
                                    three();
                                if (playthis == 0 || playthis == 99)
                                    four();
                                if (playthis == 0 || playthis == 99)
                                    five();
                            

                            if (playthis == 0 || playthis == 99)
                                hihi();
                        }
                        else if (base1.highbider == mate)
                        {
                            two();
                            if (playthis == 0 || playthis == 99)

                                
                                    four();
                                         if (playthis == 0 || playthis == 99)
                                    five();
                                 
                            //jodi mate and amar pawar kon chance na thake then
                            if (playthis != 0&&playthis!=99 && playthis % 10 >= 5 && base1.number_of_card[playthis / 10] <= 4)
                                playthis = 0;


                            if (playthis == 0 || playthis == 99)
                                hihi();

                        }
                        else                              //oppponent
                        {
                            int pl = 0;
                            int tnoo = 0;
                            int ldcc = base1.cardlead[trumpcard, 0];        //trum er lead thakle place it
                            for (int i = 0; i <= 7; i++)
                            {if (temp[i] == ldcc && base1.tshown == 1 && ldcc != 0&&ldcc%10!=8)
                                    pl = temp[i];
                            if (temp[i] / 10 == trumpcard && base1.tshown == 1)
                                tnoo++;
                            }
                            

                            playthis = pl;

                            if ((playthis == 0 || playthis == 99 ) && base1.tshown == 1)       //lead trum nae but lead er nicherta ache
                            {
                                int scd = ldcc - 1;
                                int pll = 0, min = 99, tno = 0;
                                for (int i = 0; i <= 7; i++)
                                {
                                    if (temp[i] == scd)
                                        pll = 1;
                                    if (temp[i] / 10 == trumpcard && temp[i] < min)
                                    { min = temp[i]; tno++; }
                                }
                                if (pll == 1 && tno >= 3)                //lead trump nae er nicher ta ache p-lace min tr to out lead
                                {
                                    /* for (int i = 0; i <= 7; i++)
                                         if (temp[i] / 10 == trumpcard && temp[i] < scd && pll == 1)
                                             pll = temp[i];*/
                                    playthis = min;
                                }


                            }

                            if (playthis == 0 || playthis == 99)
                                two();


                           
                                if (playthis == 0 || playthis == 99)
                                three();
                            if (playthis == 0 || playthis == 99)
                                four();
                            if (playthis == 0 || playthis == 99)
                                five();
                        
                            



                            if (playthis == 0 || playthis == 99)
                                hihi();


                        }


                    }
                }//4th player na ends




                nonvalidoptioncard = 0;
                if (!valid(who))
                {

                    playthis = nonvalidoptioncard;

                }

                for (int i = 0; i < 8; i++)
                {

                    if (temp[i] == playthis)
                        selectedcardpos = i;

                }


                if (base1.tshown == 0 && playthis / 10 == trumpcard)
                    base1.aloowt[who] = 1;

                base1.onhandc[playthis / 10, playthis % 10] = 0;
                base1.number_of_card[playthis / 10]--;

                return playthis;


            }
            else
                return 88;
        }

        /// <summary>
        /// i dont have running type and trumps play
        /// </summary>
        public void tyes()  //jehtu trm nae so minimum
        {
            int iam,nxtman=0;
            if (ii == 2) nxtman = mate - 1;
            if (nxtman == 0) nxtman = 4;
            if (ii == 3) nxtman = 7;
            
            int opn1, opn2;
            opn1 = mate + 1;
            if (opn1 == 5) opn1 = 1;
            opn2 = opn1 + 2;
            if (opn2 == 5) opn2 = 1;
            if (opn2 == 6) opn2 = 2;

            int minim = 99, minni = 9, mxx = 0,mx=0;
            for (int i = 0; i <= 7; i++)
            {
                if (temp[i] != 0 && temp[i] % 10 < minni) { minim = temp[i]; minni = temp[i] % 10; }
                if (temp[i] != 0 && temp[i]%10 > mx) {mx=temp[i]%10;mxx = temp[i];}
            }

            playthis = minim;
            if (base1.everyonehave[running, opn1] == -1 && base1.everyonehave[running, opn2] == -1 && (mxx != base1.cardlead[mxx / 10, 0] || (mxx == base1.cardlead[mxx / 10, 0]&&base1.number_of_card[mxx/10]<=4))) //oponent er trm nae so max and max ta lead na
                playthis = mxx;

            if (gett == mate && base1.everyonehave[running, nxtman] == -1 && (mxx != base1.cardlead[mxx / 10, 0] || (mxx == base1.cardlead[mxx / 10, 0] && base1.number_of_card[mxx / 10] <= 4)))    //porer joner trm nae and marta lead na kon kichur
                playthis = mxx;

            if (gett == mate && ii == 3 || base1.onboard[mate] == base1.cardlead[running, 0] && (mxx != base1.cardlead[mxx / 10, 0] || (mxx == base1.cardlead[mxx / 10, 0] && base1.number_of_card[mxx / 10] <= 4)))  //lead save
                playthis = mxx;
            if (playthis == 0 || playthis == 99)
                playthis = minnor;


        }

        /// <summary>
        /// i dont have this card and trump not shown
        /// </summary>
        public void TNS()
        {
            int ihavtr = 0, imintr = 99, imaxtr = 0;
            int leadtr = base1.cardlead[trumpcard, 0];
            for (int i = 0; i <= 7; i++)                   //saves max trm, min trm
                if (temp[i] / 10 == trumpcard && temp[i] != 0)
                {
                    ihavtr++;

                    if (imintr > temp[i]) imintr = temp[i];
                    if (imaxtr < temp[i]) imaxtr = temp[i];

                }

            if (ihavtr >= 1)//i have trump
            {
                int sectr = base1.cardlead[trumpcard, 1];
                int yetpoint = 0, fldpoint = 0;
                for (int i = 1; i <= 4; i++)                    //yet board a koto point
                { if (base1.onboard[i] != 0)yetpoint += base1.point[base1.onboard[i] % 10]; }
                for (int i = 1; i <= 8; i++)
                { if (base1.onhandc[running, i] != 0) fldpoint += base1.point[i]; } //field a r koto point ache

                if ((base1.highbider == opmate && base1.everyonehave[running, opmate] <= 0) || fldpoint + yetpoint <= 2)        //field a point <=2
                    playthis = imintr;
                if ((base1.highbider == opmate && base1.everyonehave[running, opmate] <= 0) || fldpoint + yetpoint > 2)        //field a point <=2
                {
                    playthis = imaxtr;
                    if (base1.number_of_card[running] > 4 && base1.everyonehave[running, opmate] == 1||(imaxtr==leadtr||imaxtr==sectr))      //lead trm thakle deio na
                        playthis = imintr;
                }

                if (gett != 0 && gett % 2 != mate % 2)      //age trum hoyece,mate pacche na point thakle plus over thakle over
                {
                    int lasttrum = base1.onboard[gett], mine = 0;
                    for (int i = 0; i <= 7; i++) if (temp[i] != 0 && temp[i] / 10 == trumpcard && temp[i] > lasttrum && mine == 0) mine = temp[i];
                    if (fldpoint + yetpoint >= 2)
                        playthis = mine;

                    //aage trm hoice kintu amar over nae, so no need to place trm
                    if (mine == 0)
                        playthis = 0;

                }
                if (imaxtr % 10 == 7 && ihavtr <= 2 && imaxtr != base1.cardlead[trumpcard, 0] && base1.highbider != opmate)        //9 atke jete pare emon thakle place 9
                    playthis = imaxtr;
                if (playthis == 0)  //kono condition ae pore ni orthat over trum nae. so place mini power, pointless
                {
                    playthis = imintr;
                    int picci = 9;int pictr = 9;
                    int minpolestr=0;
                    for (int i = 0; i <= 7; i++)
                    {
                        if (temp[i] % 10 < picci && temp[i] != 0&&temp[i]/10!=trumpcard)        //trump card chara onno kichur mincard
                        { picci = temp[i] % 10; playthis = temp[i]; }
                        if (temp[i] % 10 < pictr && temp[i] != 0 )              //trump soho onno kichur mincard
                        { pictr = temp[i] % 10; minpolestr = temp[i]; }

                    }
                    if (base1.point[playthis%10] >base1.point[minpolestr%10])     //jodi trump chara point thake to trum er  min chere dao
                        playthis = minpolestr;          //trum chara card mintrm er cheye boro hote hobe

                }
            }
            else//i dont have trm
            {
                int op1 = opmate, op2 = opmate + 2;
                int crdtyp = 0, crdpoint = 0, nowmin = 99, nowmax = 0;     //crdpoint point dekhbe crdtyp kon card dib thik korbe
                if (op2 == 5)
                    op2 = 1;
                if (op2 == 6) op2 = 2;
                for (int j = 1; j <= 4; j++)
                {
                    if ((base1.everyonehave[j, op1] == -1 || base1.everyonehave[j, op2] == -1) && base1.number_of_card[trumpcard] > 0 && base1.onboard[mate] != 0 && base1.onboard[op1] != 0 && base1.onboard[op2] != 0) //find kon card a oponent trum korbe next a
                    {
                        for (int i = 0; i <= 7; i++)
                        {
                            if (temp[i] / 10 == j && crdpoint < temp[i] % 10)        //ami 4th player
                            {
                                crdpoint = temp[i] % 10;
                                crdtyp = temp[i];
                            }
                        }

                    }


                }


                int m = 9, mm = 0, max = 0, mx = 0;
                for (int i = 0; i <= 7; i++)
                {
                    if (temp[i] != 0 && temp[i] % 10 < m)
                    {
                        mm = temp[i]; m = temp[i] % 10;
                        
                    }
                    if (temp[i] != 0 && temp[i] % 10 > mx)
                    {
                        mx = temp[i] % 10; max = temp[i];
                    }
                }
                int nxmn = mate - 1;
                if (nxmn == 0) nxmn = 4;
                if (gett != 0 && gett == mate && base1.onboard[mate] != 0 && base1.onboard[op1] != 0 && base1.onboard[op2] != 0)      //mate pacche eta sure holei max
                    playthis = crdtyp;
                if (gett == 0 && getrun == mate &&getrun!=0&& base1.onboard[mate] != 0 && base1.onboard[op1] != 0 && base1.onboard[op2] != 0)
                    playthis = crdtyp;
                if (gett == 0 && getrun == mate && getrun != 0 && base1.onboard[mate] != 0 && ii == 2 && base1.everyonehave[base1.trumph[base1.highbider], nxmn] == -1)
                    playthis = crdtyp;
                if ((getrun == mate && getrun != 0 && base1.everyonehave[trumpcard, op1] == -1 && base1.everyonehave[trumpcard, op2] == -1 && base1.cardlead[running, 0] == base1.onboard[mate]) || (getrun == mate && getrun != 0 && base1.number_of_card[running] <= 0 && base1.number_of_card[trumpcard] <= 0))//karo kache trm nae, etai lead
                    playthis = max;

                if (playthis == 0 || playthis == 99)
                {

                    playthis = mm;


                }

            }


        }


        public void two()           //find another cards lead that will not be trumped
        {
            int ldcsu = 0, ldc = 0, su = 0, notsu = 0, prev = 0,dnpl=0;

            int op1=mate+1,oppon=0;
            if(op1==5)op1=1;
            int op2=mate-1;
            if(op2==0)op2=1;
            int pos1=0,pos2=0;
            if(ii==0)

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 0; j <= 7; j++)
                        if (base1.cardlead[i, 0] == temp[j] && base1.cardlead[i, 0] != 0)
                        { //ldc = temp[j]; 

                            if (ii == 0)           //first
                            {
                                if ((base1.everyonehave[i, op1] == -1 && base1.everyonehave[trumpcard, op1] != -1) || (base1.everyonehave[i, op2] == -1 && base1.everyonehave[trumpcard, op2] != -1)||base1.number_of_card[i]<=4)
                                    dnpl = 1;
                                else
                                    ldc = temp[j];

                                
                            }

                            if (ii > 0 && ii < 3)
                            {

                                oppon = mate - 1;
                                if (oppon == 0) oppon = 1;

                                if (base1.everyonehave[i, oppon] == -1 && base1.everyonehave[trumpcard, oppon] != -1)
                                    dnpl = 1;
                                else
                                    ldc = temp[j];

                                
                            }


                            /*   for (int k = 1; k <= 4; k++)
                               {
                                   if (base1.everyonehave[i, k] == 0)
                                       notsu++;
                                   if (base1.everyonehave[i, k] == -1)
                                       notsu += 2;
                                   if (base1.everyonehave[i, k] == 1)
                                       su++;
                               }
                               if (su + base1.number_of_card[i] - notsu > prev)
                               { prev = su + base1.number_of_card[i] - notsu; ldc = temp[j]; 


                           }*/

                        }
                }
            playthis = ldc;

        }

        public void three()     //surely be trumped +mate will not suffer
        {
            int sel = 0, nest = 0, cf = 99;
            for (int i = 1; i <= 4; i++)
            {
                if (i != trumpcard)
                {

                    if (base1.number_of_card[i] <= 3 && base1.everyonehave[i, mate] <= 0 && base1.tot_po[i] <= 3)
                        sel = i;

                }

            }

            for (int i = 0; i <= 7; i++)
            {
                if (temp[i] != 0 && temp[i] / 10 == sel && temp[i] < cf)
                    cf = temp[i];
            }
            playthis = cf;


        }

        public void four()      //find mate will trum for sure
        {
            int sel = 0, nest = 0, cf = 0;
            for (int i = 1; i <= 4; i++)
            {
                if (i != trumpcard)
                {

                    if (base1.everyonehave[i, mate] == -1 && base1.everyonehave[trumpcard, mate] == 1)
                        sel = i;

                }

            }
            for (int i = 0; i <= 7; i++)
            {
                if (temp[i] != 0 && temp[i] / 10 == sel && temp[i] > cf)
                    cf = temp[i];
            }
            playthis = cf;


        }

        public void five()          //lastman will not trum 
        {
            int lm = base1.roundfirst - 1, cc=9, card = 99;
            if (lm == 0)
                lm = 4;
            for (int i = 1; i <= 4; i++)
                if (base1.everyonehave[i, lm] == 1 && i != trumpcard)
                {
                    for (int j = 0; j <= 7; j++)
                        if (temp[j] / 10 == i && cc > temp[j] % 10) { card = temp[j]; cc = temp[j] % 10; }


                }
            playthis = card;

        }

        
        
        ////....

        public void whogetthis()
        {
            //////////////////////////calculating how many card left and who is getting this round now
            ////
            ///////////
            whogets = 0; gett = 0; getrun = 0; trump = 0; cardp = 0; pointonboard = 0;

            for (int h = 1; h <= 4; h++)
            {
                int typ, rank;
                if (base1.onboard[h] != 0)
                {
                    if (base1.onboard[h] % 10 == 8)
                        pointonboard += 3;
                    else if (base1.onboard[h] % 10 == 7)
                        pointonboard += 2;
                    else if (base1.onboard[h] % 10 == 6)
                        pointonboard += 1;
                    else if (base1.onboard[h] % 10 == 5)
                        pointonboard += 1;

                    typ = base1.onboard[h] / 10;
                    rank = base1.onboard[h] % 10;

                    base1.onhandc[typ, rank] = 0;

                    if (base1.tshown == 1 && base1.onboard[h] / 10 == base1.trumph[base1.highbider])
                    {
                        if (trump < base1.onboard[h])
                        {
                            gett = h; //who gets this round by high trumph till now
                            trump = base1.onboard[h];
                        }

                    }
                    else if (base1.onboard[h] / 10 == running)
                    {
                        if (cardp < base1.onboard[h])
                        {
                            getrun = h; //who gets this round by running card
                            cardp = base1.onboard[h];
                        }
                    }

                }

            }
            ///....

            if (gett != 0)  //trm places pabe
                getrun = 0;
        }

        public void whichcardhowmany()
        {
            //base1.number_of_card = 0;

            hrt = 0; clb = 0; spd = 0; dic = 0; trum = 0;
            ///which card how much left except mine
            ///
            for (int j = 1; j <= 8; j++)    //on hands
            {
                if (base1.onhandc[1, j] == 1)
                    hrt++;
                if (base1.onhandc[2, j] == 1)
                    clb++;
                if (base1.onhandc[3, j] == 1)
                    dic++;
                if (base1.onhandc[4, j] == 1)
                    spd++;



            }



        }
        ////


        public void sortar()
        {




            int[] tempr = new int[10];
            for (int i = 1; i <= 4; i++) //which card
            {
                for (int j = 0; j <= 7; j++) //what point
                    tempr[j] = base1.cardlead[i, j];

                Array.Sort(tempr);
                Array.Reverse(tempr);

                for (int k = 0; k <= 7; k++)
                    base1.cardlead[i, k] = tempr[k];


            }

        }
        ///

        public bool valid(int whoo)
        {
            int smhav = 0;
            int tempuuu = 9, tcd = 0;
            if ((playthis / 10 == running || base1.roundfirst == whoo) && playthis > 10 && playthis < 50)
                smhav = 0;
            else
            {
                for (int i = 0; i <= 7; i++)                         //running card thakle
                {
                    if (temp[i] / 10 == running && nonvalidoptioncard == 0 && temp[i] != 0)
                    {
                        smhav = 1;
                        nonvalidoptioncard = temp[i];                    //option B to avoid wrong play
                    }

                    if (temp[i] != 0 && temp[i] % 10 < tempuuu)        //running card nae;
                    {
                        smhav = 1;
                        tempuuu = temp[i] % 10;
                        tcd = temp[i];               //option B to avoid wrong play
                    }

                }
                if (nonvalidoptioncard == 0 && playthis != 0 && playthis != 99)      //means running card nae so everything is ok
                    smhav = 0;
                else
                {

                    if (nonvalidoptioncard == 0)
                        nonvalidoptioncard = tcd;
                }

            }

            if (smhav == 0)
                return true;
            else
                return false;

        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // AI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(1194, 727);
            this.Name = "AI";
            this.Load += new System.EventHandler(this.AI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AI_Load(object sender, EventArgs e)
        {

        }

    }


}


/*  if (who == 2)
            {
                int i = 0;
                while (base1.secondc[i] == 0 && i<=7)
                {
                    i++;
                }
                playthis = base1.secondc[i];
                base1.secondc[i] = 0;

            
            }
            else if (who == 3)
            {
                int i = 0;
                while (base1.thirdc[i] == 0 && i <= 7)
                {
                    i++;
                }
                playthis = base1.thirdc[i];
                base1.thirdc[i] = 0;
            
            }
            else if (who == 4)
            {

                int i = 0;
                while (base1.forthc[i] == 0 && i <=7)
                {
                    i++;
                }
                playthis = base1.forthc[i];
                base1.forthc[i] = 0;
                string path = @"E:\visc#\WIN_forms_app\29-card\29-card\Resources\";
                    string pa = "";
                    pa += path + "\\" + playthis.ToString() + ".png";
                

            
           }*/
