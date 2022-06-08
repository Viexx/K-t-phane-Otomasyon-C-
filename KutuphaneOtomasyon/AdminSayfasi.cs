using KutuphaneOtomasyon.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class AdminSayfasi : Form
    {
        List<kisi> kisilerim;
        List<kitap> kitaplarım;

        public AdminSayfasi(List<kisi> kisilerim , List<kitap> kitaplarım )
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarım = kitaplarım;
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach(kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(),kisi.getIsım(),kisi.getSoyisim(),kisi.getOlusturmatarih(),kisi.getKullaniciAdi(),kisi.getSifre(),kisi.getYetki());
            }

            foreach(kitap kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getkitapID(), kitap.getkitapIsım(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getyayınEvi(), kitap.gettur(), kitap.getadet(), kitap.getsayfaSayisi(), kitap.getbasımYili());

            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, mtxt_box_ot.Text, txt_kullaniciad.Text, txt_sifre.Text, txt_yetki.Text);
        }
        public void textleriDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtxt_box_ot.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string olusturmatarih = mtxt_box_ot.Text;
            string kullaniciad = txt_kullaniciad.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, olusturmatarih, kullaniciad, sifre, yetki);
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<groupBox1.Controls.Count;i++)
            {
                if(groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapisim.Text, txt_kitapYazar.Text, txt_dil.Text, txt_yayınevi.Text, txt_tür.Text, txt_adet.Text, txt_sayfa.Text, txt_basımyılı.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapguncel_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapisim = txt_kitapisim.Text;
            string kitapyazar = txt_kitapYazar.Text;
            string dil = txt_dil.Text;
            string yayinEvi = txt_yayınevi.Text;
            string tur = txt_tür.Text;
            string adet = txt_adet.Text;
            string sayfa = txt_sayfa.Text;
            string basımyili = txt_basımyılı.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapisim, kitapyazar, dil, yayinEvi, tur, adet, sayfa, basımyili);



        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if(groupBox2.Controls[i] is TextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapYazar.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayınevi.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tür.Text= dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text= dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfa.Text= dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basımyılı.Text= dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kisi hedefkisi = null;

            int secilenId = Convert.ToInt32(txt_arakisiID.Text);

            foreach (kisi kisi in kisilerim)
            {
                if(kisi.getId()==secilenId)
                {
                    hedefkisi = kisi;
                    break;
                }

            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsım(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmatarih(), hedefkisi.getKullaniciAdi(), hedefkisi.getSifre(), hedefkisi.getYetki());

        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach(kisi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsım(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmatarih(), hedefkisi.getKullaniciAdi(), hedefkisi.getSifre(), hedefkisi.getYetki());

            }

            txt_arakisiID.Text = string.Empty;
        }

        private void btn_arakitap_Click(object sender, EventArgs e)
        {
            kitap hedefkitap = null;

            int secilenkitapID = Convert.ToInt32(txt_arakitap.Text);

            foreach(kitap kitap in kitaplarım)
            {
                if (kitap.getkitapID() == secilenkitapID)
                {
                    hedefkitap = kitap;
                    break;

                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapID(), hedefkitap.getkitapIsım(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayınEvi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getbasımYili());
        }

        private void btn_yenilekitap_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (kitap hedefkitap in kitaplarım)
            {
                dataGridView2.Rows.Add(hedefkitap.getkitapID(), hedefkitap.getkitapIsım(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayınEvi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getbasımYili());
            }


            txt_arakitap.Text = string.Empty;

        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Başarılı bir şeklide çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
