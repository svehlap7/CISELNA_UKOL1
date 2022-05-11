using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISELNE_UKOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Prvo(int cisla)
        {

            if (cisla == 1 || cisla == 0)
            {
                return false;
            }

            if (cisla % 2 == 0 && cisla != 2)
            {
                return false;
            }

            for (int cisla2 = 3; cisla2 <= Math.Sqrt(cisla); cisla2 += 2)
            {
                if (cisla % cisla2 == 0)
                {
                    return false;
                }

            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            Random nd = new Random();
            listBox1.Items.Clear();
            bool prvocislo = false;
            int cislo = 0;
            for (int i = 0; i < n && !prvocislo; i++)
            {
                cislo = nd.Next(5, 121);
                listBox1.Items.Add(cislo);
                prvocislo = Prvo(cislo);

            }
            if (prvocislo)
            {
                MessageBox.Show("Prvocislo je: " + cislo);
            }
            else
            {
                MessageBox.Show("nenalezeno");
            }
        }
    }
}
