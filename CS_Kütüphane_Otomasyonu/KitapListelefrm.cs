﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Kütüphane_Otomasyonu
{
    public partial class KitapListelefrm : Form
    {
        public KitapListelefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-5L1LUNIR;Initial Catalog=CS_KUTUPHANEOTOMASYONU;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kitap", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }
        private void KitapListelefrm_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from kitap where barkodno = @barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("silme işlemi gerçekleşti");
                daset.Tables["kitap"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitap set kitapadi=@kitapadi,yazari=@yazari,yayinevi=@yayinevi,sayfasayisi=@sayfasayisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi",txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari",txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi",txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi",txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu",comboTuru.Text);
            komut.Parameters.AddWithValue("@stoksayisi",txtStok.Text);
            komut.Parameters.AddWithValue("@rafno",txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama",txtAciklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            daset.Tables["kitap"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kitap where barkodno like '%" + txtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(daset, "kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from kitap where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazar.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
                comboTuru.Text = read["turu"].ToString();
                txtStok.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtAciklama.Text = read["aciklama"].ToString();
            }
            baglanti.Close();
        }
    }
}
