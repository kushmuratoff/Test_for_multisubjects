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
    public partial class fio : Form
    {
        string s;
        public fio()
        {
            InitializeComponent();
        }
         public string olish()
        {
            
            return s;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length<=0)
            {
                MessageBox.Show("ma'lumot kiritildi");
            }
            else
            {
              //  olish();
                yechim ye = new yechim(textBox1.Text);
                this.Hide();
                ye.ShowDialog();
                Close();
                this.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
        }

        private void fio_Load(object sender, EventArgs e)
        {
            StreamReader uqish = new StreamReader(Application.StartupPath + "\\ismlar.txt");
            string ismlar;
            while(uqish.Peek()>0)
            {
                ismlar = uqish.ReadLine();
                comboBox1.Items.Add(ismlar);

            }
            uqish.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }
    }
}
