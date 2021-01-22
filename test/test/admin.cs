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
    public partial class admin : Form
    {
        String olish="";
        TextBox tb;
        Label lb;
        Button bn;
        RichTextBox rch;
        Button bn1;
        RichTextBox rch1;
        bool par = false;
        private int tsoni=0;
        string fan = "";
        string nazorati = "_";

        
        public admin()
        {
            InitializeComponent();
        }

       

        private void parolozgartirishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            par = false;
            tb = new TextBox();
            tb.Left = 150;
            tb.Top = 50;
            tb.Width = 150;
            tb.Height = 20;
            Controls.Add(tb);
            lb = new Label();
            lb.Text = "eski parol";
            lb.Left = 50;
            lb.Top = 50;
            Controls.Add(lb);
            bn = new Button();
            bn.Click += new EventHandler(bn_c);

            bn.Text = "ok";
            bn.Name = "but";
            bn.Top = 75;
            bn.Left=150;
            bn.Width = 40;
            bn.Height = 20;
            Controls.Add(bn);
        }
        protected void bn_c(object sender,EventArgs e)
        {
            Button bn=sender as Button;
            if (par == true)
            {
                 StreamWriter sq = new StreamWriter(Application.StartupPath + "\\parol.txt");

                       sq.WriteLine(tb.Text); 
                        sq.Close();
                        MessageBox.Show("parol saqlandi");
                        tb.Dispose();
                        lb.Dispose();
                        bn.Dispose();
            }
            else
            {
                if (tb.Text ==olish)
                {
                    lb.Text = "yangi parol kiriting ";
                    tb.Clear();
                    par = true;
                }
                else { MessageBox.Show("xato kiritildi "); }
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            StreamReader sq1 = new StreamReader(Application.StartupPath + "\\parol.txt");
                olish = sq1.ReadLine();
            sq1.Close();
        }

        private void testqushishToolStripMenuItem_Click(object sender, EventArgs e)
        {
                   }

        public void joylashtirish()
        {
            
            rch = new RichTextBox();
            rch.Left = 50;
            rch.Top = 50;
            rch.Width = 300;
            rch.Height = 400;
            Controls.Add(rch);
            bn = new Button();
            bn.Click += new EventHandler(bn_qushish);
            bn.Name = "name";
            bn.Text = "saqlash";
            bn.Left = 380;
            bn.Top = 50;
            bn.Width = 60;
            bn.Height = 20;
            Controls.Add(bn);
            rch1 = new RichTextBox();
            rch1.Left = 380;
            rch1.Top = 80;
            rch1.Width = 150;
            rch1.Height = 180;
            Controls.Add(rch1);
            StreamReader sq = new StreamReader(Application.StartupPath + "\\" + fan + ".txt");
            olish = "";
            while (sq.Peek() > 0)
            {
                olish = sq.ReadLine();
                rch.Text += olish + "\n";
            }
            sq.Close();
            StreamReader sq1 = new StreamReader(Application.StartupPath + "\\nazorat" + nazorati + ".txt");
            olish = "";

            while (sq1.Peek() > 0)
            {
                olish = sq1.ReadLine();
                rch1.Text += olish + "\n";
            }
            sq1.Close();
        }
        protected void bn_uzgartirish(object sender, EventArgs e)
        {
            Button bn = sender as Button;
            olish = "";
            int soni = 0, w = 0;
            StreamReader te = new StreamReader(Application.StartupPath + "\\"+fan+".txt");
            while (te.Peek() > 0)
            {

                String qator = te.ReadLine();

                if ((qator.Substring(0, 1) == "|" || qator.Substring(0, 1) == "#" || qator.Substring(0, 1) == "@") && w == 1)
                {
                    soni++;
                }

                else { w = 1; }
            } soni++;
            //  MessageBox.Show(soni.ToString());
            te.Close();
            tsoni = Convert.ToInt16(rch.Lines[5]);

            StreamWriter saqlash = new StreamWriter(Application.StartupPath + "\\nazorat"+nazorati+".txt");
            for (int i = 0; i < rch.Lines.Count()-1; i++)
            {
                if (i == rch.Lines.Count() - 2) { saqlash.WriteLine((soni/tsoni).ToString()); continue; }
                saqlash.WriteLine(rch.Lines[i]);

            }

            saqlash.Close();
            MessageBox.Show("saqlandi");
            rch.Dispose();
            bn.Dispose();
        }

        private void chiqishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void testniboshqarishToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qollanmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bu testga savol qushish uchun savol boshiga  | belgisini qushib yozing to'g'ri javob oldidan # belgisi noto'g'ri javob oldidan @ belgisi qushiladi");
        }

        private void matematikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fan = "";
            nazorati = "_";
            fan = "matematika";
            nazorati += "m";
            joylashtirish();

           
        }
        protected void bn_qushish(object sender, EventArgs e)
        {
            Button bn = sender as Button;
            StreamWriter saqlash = new StreamWriter(Application.StartupPath + "\\"+fan+".txt");
            for (int i = 0; i < rch.Lines.Count()-1;i++ )
            {
                saqlash.WriteLine(rch.Lines[i]);

            }
            saqlash.Close();

            StreamWriter saqlash1 = new StreamWriter(Application.StartupPath + "\\nazorat" + nazorati + ".txt");
            for (int i = 0; i < rch1.Lines.Count(); i++)
            {
                saqlash1.WriteLine(rch1.Lines[i]);

            }
            saqlash1.Close();
                MessageBox.Show("saqlandi");

                olish = "";
                int soni = 0, w = 0;
                 soni++;
                int uchh = 0,uz=0;
            
            while(uchh<rch.Lines.Count()-1)
            {
                if (rch.Lines[uchh].Substring(0, 1) == "|") { uz++; }
                uchh++;
            }
                //MessageBox.Show(rch.Lines.Count().ToString()+uz.ToString());
                //  MessageBox.Show(soni.ToString());
                
                tsoni = Convert.ToInt16(rch1.Lines[5]);

                StreamWriter saqlash3 = new StreamWriter(Application.StartupPath + "\\nazorat" + nazorati + ".txt");
                for (int i = 0; i < rch1.Lines.Count() - 1; i++)
                {
                    if (i == rch1.Lines.Count() - 2) { saqlash3.WriteLine((uz).ToString()); continue; }
                    saqlash3.WriteLine(rch1.Lines[i]);

                }

                saqlash3.Close();
                rch1.Dispose();
                rch.Dispose();
                bn.Dispose();
                


        }

        private void fizikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fan = "";
            nazorati = "_";
            fan = "fizika";
            nazorati += "f";
            joylashtirish();


        }

        private void ingliztiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fan = "";
            nazorati = "_";
            fan = "ingliz_tili";
            nazorati += "i";
            joylashtirish();

        }
        
        
    }
}
