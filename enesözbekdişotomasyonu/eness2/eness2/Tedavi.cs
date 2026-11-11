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
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from TedaviTbl";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from TedaviTbl where TAd like '%" + ARATB.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            TedaviAdiTb.Text = "";
            TutarTb.Text = "";
            AciklamaTb.Text = "";
        }
        private void Tedavi_Load(object sender, EventArgs e)
        {
            uyeler();
            Reset();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "insert into TedaviTbl values('" + TedaviAdiTb.Text + "','" + TutarTb.Text + "','" + AciklamaTb.Text + "')";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Tedavi İşlemi Başarıyla Eklendi");
                uyeler();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek Tedavi İşlemini Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Update TedaviTbl set TAd='" + TedaviAdiTb.Text + "',TUcret='" + TutarTb.Text + "',TAciklama='" + AciklamaTb.Text + "' where TId=" + key + ";";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi İşlemi Başarıyla Güncellendi");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Tedavi İşlemini Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Delete  from TedaviTbl where TId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi İşlemi Başarıyla Silindi");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TedaviDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           TedaviAdiTb.Text = TedaviDGV.SelectedRows[0].Cells[1].Value.ToString();
            TutarTb.Text = TedaviDGV.SelectedRows[0].Cells[2].Value.ToString();
            AciklamaTb.Text = TedaviDGV.SelectedRows[0].Cells[3].Value.ToString();
           
            if (TedaviAdiTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TedaviDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            Anasayfa ana=new Anasayfa();
            ana.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tedavi tdv = new Tedavi();
            tdv.Show();
            this.Hide();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            Randevu rnd = new Randevu();
            rnd.Show();
            this.Hide();
        }

       

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Reçeteler rct = new Reçeteler();
            rct.Show();
            this.Hide();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void ARATB_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void lobi_Click(object sender, EventArgs e)
        {
            Form1 lbi = new Form1();
            lbi.Show();
            this.Hide();
        }
    }
}
