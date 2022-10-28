using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_Kütüphane_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 1; i < 256; i++)
            //{
            //    Form1 form1 = new Form1();
            //    form1.BackColor = Color.FromArgb(2,2,i);
            //}
            

        }

        private void btnuyeekle_Click(object sender, EventArgs e)
        {
            frmuyeekle frmuyeekle = new frmuyeekle();
            frmuyeekle.ShowDialog();
        }

        private void btnuyelistele_Click(object sender, EventArgs e)
        {
            frmUyeListele frmUyeListele = new frmUyeListele();
            frmUyeListele.ShowDialog();
        }

        private void btnkitekle_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapEklefrm = new KitapEklefrm();
            kitapEklefrm.ShowDialog();
        }

        private void btnkitlistele_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitapListelefrm = new KitapListelefrm();
            kitapListelefrm.ShowDialog();
        }

        private void btnkitverme_Click(object sender, EventArgs e)
        {
            EmanetKitapVerfrm emanetKitapVerfrm = new EmanetKitapVerfrm();
            emanetKitapVerfrm.ShowDialog();
        }

        private void btnkitlisteleme_Click(object sender, EventArgs e)
        {
            EmanetKitapListelefrm emanetKitapListelefrm = new EmanetKitapListelefrm();
            emanetKitapListelefrm.ShowDialog();
        }

        private void btnkitiade_Click(object sender, EventArgs e)
        {
            EmanetKitapİadefrm emanetKitapİadefrm = new EmanetKitapİadefrm();
            emanetKitapİadefrm.ShowDialog();
        }

        private void btnsıralama_Click(object sender, EventArgs e)
        {
            Sıralamafrm sıralamafrm = new Sıralamafrm();
            sıralamafrm.ShowDialog();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            Grafikfrm grafikfrm = new Grafikfrm();  
            grafikfrm.ShowDialog();
        }
    }
}
