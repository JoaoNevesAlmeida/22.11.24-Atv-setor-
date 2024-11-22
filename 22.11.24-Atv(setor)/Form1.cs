using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11._24_Atv_setor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] numeros = new int[10];
            int[] a = new int[10];
            int[] b = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = random.Next(0, 100);
                if (i % 2 == 0)
                {
                    b[i] = a[i] * 5;
                    listBox2.Items.Add(b[i]);
                }
                else
                {
                    b[i] = a[i] + 5;
                    listBox3.Items.Add(b[i]);
                }
                listBox1.Items.Add(a[i]);
            }          
        }
    }
}
