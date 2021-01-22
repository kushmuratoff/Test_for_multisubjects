using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class yechim : Form
    {
        testing ob = new testing();
       private string[] t=new string[300];
       private string[] t_u;
       string fan = "";
       string nazorati = "_";
        int[] son;
        int k = 0,savol=0;
        int oxiri=0;
        int n = 0,test_uz=0;
        int r = 0,ind=0;
        int vaqt = 0,sekund=0;
        private int soni = 0;
        Random ra = new Random();
        private int[] aa;
        private int[] urni;
        private int tugriligi=0;
        public bool bosildi = true;

        bool tugri = true;
        fio fam = new fio();

        string fio;
        public yechim()
        {
            InitializeComponent();
        }
        public yechim(string f)
        {
            this.fio = f;
            InitializeComponent();
         
            label8.Text = fio;
        }

        private void yechim_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            progressBar1.Visible = false;

             
            }
       public string olish(int x,string suz)
        {
            for (int i = x*savol; i < x * savol + savol;i++ )
            {
                if (t[i].Substring(0, 1) == suz) {  return t[i]; }
            }
            return "s";
              
        }
       public string olish1(int x, string suz,int k)
       {
            return t[x * savol + k]; 
          
       }

          public void yechish()
        {
            if (tugri == true)
            {
              
                k = aa[ind] * 5;

                label1.Text =(urni[ind]).ToString()+". "+ t_u[k].Substring(1,t_u[k].Length-1);
                label2.Text = t_u[k + 1].Substring(1, t_u[k+1].Length - 1);
                label3.Text = t_u[k + 2].Substring(1, t_u[k+2].Length - 1);
                label4.Text = t_u[k + 3].Substring(1, t_u[k+3].Length - 1);
                label5.Text = t_u[k + 4].Substring(1, t_u[k+4].Length - 1);
                
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            else
            {
                int t;
                for (int i = ind; i < oxiri - 1; i++)
                {
                   
                    t = urni[i]; urni[i] = urni[i + 1]; urni[i + 1] = t;
                    t = aa[i]; aa[i] = aa[i + 1]; aa[i + 1] = t;
                }
                tugri = true;
                yechish();
            }
                

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked)
            {

                if (soni < oxiri - 1) { ind++; yechish(); }
                soni++;
                label6.Text = soni.ToString() + "/" + oxiri.ToString();
                

            }
            else
            {
                tugri = false;
                yechish();

            }
           
            if(soni==oxiri)
             {
                 tugash();
            }
            tugriligi = 0;
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (bosildi == true)
            {
                if (checkBox1.Checked)
                {
                    if (t_u[k + 1].Substring(0, 1) == "#" && tugriligi == 0) { r++; tugriligi = 1; }
                }
                if (checkBox2.Checked)
                {
                    if (t_u[k + 2].Substring(0, 1) == "#" && tugriligi == 0) { r++; tugriligi = 1; }
                }
                if (checkBox3.Checked)
                {
                    if (t_u[k + 3].Substring(0, 1) == "#" && tugriligi == 0) { r++; tugriligi = 1; }
                }
                if (checkBox4.Checked)
                {
                    if (t_u[k + 4].Substring(0, 1) == "#" && tugriligi == 0) { r++; tugriligi = 1; }
                }
                bosildi = false;
            }
            else
            {
                bosildi = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

            }

        }
        public void tugash()
        {
            timer1.Enabled = false;
            MessageBox.Show("tugadi");
            MessageBox.Show("siz " + oxiri.ToString() + " dan " + r.ToString() + " tasiga javob toptingiz ");
            Close();
        }
       

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (sekund < vaqt)
            {
                sekund++;
                label7.Text = ((sekund / 60) % 60).ToString() + ":" + (sekund % 60)
                    .ToString() + "/" + (vaqt/60).ToString() + ":" + (vaqt%60).ToString();
            

                
                progressBar1.Value = sekund;
            }

            else {  tugash(); }
          
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("fan_tanlanmadi   fan tanlang");
            }
            else
            {
                if (radioButton1.Checked == true) { fan = "matematika"; nazorati += "m"; testni_boshlash(); }
                else if (radioButton2.Checked == true) {  fan = "fizika"; nazorati += "f"; testni_boshlash(); }
                else if (radioButton3.Checked == true) { fan = "ingliz_tili"; nazorati += "i"; testni_boshlash(); }
            }
            button1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            progressBar1.Visible = true;


        }
        public void testni_boshlash()
        {

             StreamReader sq = new StreamReader(Application.StartupPath +"\\"+ fan+".txt");
            string test = "";
            int w = 0;
                while (sq.Peek() > 0)
                {
                   
                    String qator = sq.ReadLine();
                  
                  if ((qator.Substring(0, 1) == "|"||qator.Substring(0, 1) == "#"||qator.Substring(0, 1) == "@")&&w==1)
                  {
                      ob.ajratish(test);
                        test = ""; test += qator;
                    }
                   
                  else { w = 1; test += qator;}
                }
                ob.ajratish(test);
                
                
                t=ob.olish();
                n = t.Length ;
                
               // son = new int[n];
               // son = ob.qiymat_olish();
              

            
                sq.Close();
                StreamReader naz = new StreamReader(Application.StartupPath + "\\nazorat"+nazorati+".txt");
                while (naz.Peek() > 0)
                {
                    String ajratish = naz.ReadLine();
                    test_uz++;
                    if (test_uz == 2)
                    {
                        oxiri = Convert.ToInt32(ajratish);
                        }
                    if (test_uz == 4) 
                    {
                        for (int i = 0; i < ajratish.Length;i++ )
                        { if(ajratish.Substring(i,1)==".")
                        {
                            vaqt = 60 * Convert.ToInt32(ajratish.Substring(0, i));
                            vaqt = vaqt+ Convert.ToInt32(ajratish.Substring(i+1, 2));
                            break;

                        }
                        }
                           
                    }
                    if (test_uz == 6)
                    {
                        savol = Convert.ToInt32(ajratish);
                    }
                    if (test_uz == 8)
                    {
                        n = Convert.ToInt32(ajratish);
                    }

                }
                naz.Close();
               // MessageBox.Show(n.ToString());
               // MessageBox.Show("test boshlandi");
                aa = new int[oxiri];
                t_u = new string[oxiri * 5];
                urni = new int[oxiri];
                int joyi = 0;
                    for (ind = 0; ind < oxiri; ind++)
                    {
                    borish:

                        k = ra.Next(0, n);
                        int g = 0;
                        for (int u = 0; u < ind; u++)
                        {
                            if (k == aa[u]) { g = 1; break; }

                        }
                        if (g == 1) goto borish;
                        aa[ind] = k;
                        urni[ind] = ind + 1;
                        //olish(k, "#");
                        //MessageBox.Show(k.ToString());

                        string[] ff = new string[5];
                        ff[0] = olish(k, "|");
                        //MessageBox.Show(ff[0]);

                        ff[1] = olish(k, "#");
                        //1MessageBox.Show(ff[1]);

                        int jj = 0;

                        for (int yu = 2; yu < 5; yu++)
                        {
                            
                        nishon:
                            int ga = 0;
                            int ee = ra.Next(0, 5);
                           string  sa=olish1(k,"@",ee);
                            for (int j = 0; j < yu; j++)
                            {
                               // MessageBox.Show(ff[j].Substring(0, 1)+"  "+ff[j]);
                                if (ff[j].CompareTo(sa) == 0) { ga = 1; break; }
                            }
                            if (ga == 1) {  goto nishon; }
                            ff[yu] = sa;
                          // MessageBox.Show(sa);
                        }
                        t_u[joyi] = ff[0];
                        for(int yu=1;yu<5;yu++)
                        {
                        oo:
                            int gb = 0;
                            int ss=ra.Next(1,5);
                        for (int j = 0; j < yu; j++)
                        {
                            // MessageBox.Show(ff[j].Substring(0, 1)+"  "+ff[j]);
                            if (t_u[j+joyi].CompareTo(ff[ss]) == 0) { gb = 1; break; }
                        }
                        if (gb == 1) { goto oo; }
                        t_u[joyi + yu] = ff[ss];

                        } joyi += 5;
                       
                    }
                    for (int j = 0; j < joyi/5; j++)
                    {
                       // MessageBox.Show(t_u[j*5].ToString());
                        aa[j] = j;
                       
                    }
                   // MessageBox.Show((joyi / 5).ToString());
                 //   MessageBox.Show(joyi.ToString());
                        progressBar1.Maximum = vaqt;
                timer1.Interval = 1000;
               
                timer1.Enabled = true;
               // timer1_Tick(sender,e);
            ind = 0;
                label6.Text = soni.ToString() + "/" + oxiri.ToString();
                yechish();
             



        }
           
    }
}
