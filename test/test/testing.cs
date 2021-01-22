using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    class testing
    {
        private string[] a;
        private int n;
        private int[] son;
        private int ss;
      
        public testing()
        {
            n = 0;
            a = new string[n];
            son = new int[0];
            ss = 0;
        }
        public void ajratish(string c)
        {
           // MessageBox.Show(c);
            string[] b = new string[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = a[i];
            }
            n++;
            a = new string[n];
            for (int i = 0; i < n - 1; i++)
            {
                a[i] = b[i];
            }
            a[n - 1] = c;

        }   
        public string [] olish()
        {
           string [] q = new string[n];
           for (int i = 0; i < n; i++)
           {
               q[i] = a[i];
               //MessageBox.Show(q[i]);
           }
            return q;
        }
        public void yuk(int x)
        {
            int[] g = new int[ss];
            for(int i=0;i<ss;i++)
            {
                g[i] = son[i];

            }
            ss++;
            son = new int[ss];
            for(int i=0;i<ss-1;i++)
            {
                son[i] = g[i];
            }
            son[ss - 1] = x;
        }
        public int n_olish()
        {
            return ss;
        }
        public int [] qiymat_olish()
        {



            int[] f = new int[ss];
            for(int i=0;i<ss;i++)
            {
                f[i] = son[i];
            }
            return f;
        }

        }
    
}
