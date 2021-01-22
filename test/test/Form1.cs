using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        
       

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void testyechuvchilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminstratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parol pa = new parol();
            this.Hide();
            pa.ShowDialog();
            this.Show();
        }

        private void boshlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fio fi = new fio();
            this.Hide();
            fi.ShowDialog();
            this.Show();
        }

        private void chiqishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
