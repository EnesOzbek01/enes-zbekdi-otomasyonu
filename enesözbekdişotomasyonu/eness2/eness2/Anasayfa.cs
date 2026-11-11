using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eness2
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Randevu rnd=new Randevu();
            rnd.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hasta hst=new Hasta();
            hst.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Reçeteler rct = new Reçeteler();
            rct.Show();
            this.Hide();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {

            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();

        }

        private void lobi_Click(object sender, EventArgs e)
        {

            Form1 lbi = new Form1();
            lbi.Show();
            this.Hide();
        }
    }
}
