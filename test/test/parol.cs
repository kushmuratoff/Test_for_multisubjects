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
    public partial class parol : Form
    {
        String olish;
        public parol()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text==olish)
            {
                admin ad = new admin();
                this.Hide();
                ad.ShowDialog();
                Close();

            }
            else { MessageBox.Show("parol xato"); }
        }

        private void parol_Load(object sender, EventArgs e)
        {
            StreamReader sq = new StreamReader(Application.StartupPath + "\\parol.txt");
             while(sq.Peek()>0)
             {
                 olish = sq.ReadLine();
             }
             sq.Close();
        }
    }
}
