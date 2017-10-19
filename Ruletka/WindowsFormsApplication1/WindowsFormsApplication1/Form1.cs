using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saldo = 1000;
        int Ibid = 0;

        bool Rnd()
        {
            Random rand = new Random();

            if (rand.NextDouble() >= 0.5)
                 return false;
            else
                 return true;
        }


        private void black_Click(object sender, EventArgs e)
        {
            if (Rnd())
            {
                pierwszy.Text = "Black";
                pierwszy.ForeColor = System.Drawing.Color.Black;

                saldo += 2 * Ibid;

            }
            else
            {
                pierwszy.Text = "Red";
                pierwszy.ForeColor = System.Drawing.Color.Red;

                saldo -= Ibid;
            }

            if (saldo <= 0)
            {
                MessageBox.Show("Przegrałeś!");
            }
            Tsaldo.Text = saldo.ToString();
        }

        private void red_Click(object sender, EventArgs e)
        {
            if (Rnd())
            {
                pierwszy.Text = "Black";
                pierwszy.ForeColor = System.Drawing.Color.Black;

                saldo -= Ibid;

            }
            else
            {
                pierwszy.Text = "Red";
                pierwszy.ForeColor = System.Drawing.Color.Red;

                
                saldo += 2* Ibid;
            }

            if (saldo <= 0)
            {
                MessageBox.Show("Przegrałeś!");
            }
            Tsaldo.Text = saldo.ToString();
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (Ibid >= saldo)
            {
                MessageBox.Show("Nie masz tylu środków!");
            }
            else
            {
                Ibid += 50;
                bid.Text = Ibid.ToString();
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (Ibid > 0)
            {
                Ibid -= 50;
                bid.Text = Ibid.ToString();
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            saldo = 1000;
            Ibid = 0;

            Tsaldo.Text = saldo.ToString();
            bid.Text = Ibid.ToString();
        }

       
    }
}
