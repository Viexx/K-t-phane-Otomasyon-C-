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
    public partial class Form1 : Form
    {
        List<kisi> kişilerim = new List<kisi>();
        List<kitap> kitaplarim = new List<kitap>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullanici_adi.Text = string.Empty;
            txt_sifre.Text = string.Empty;

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_kullanici_adi.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;
            foreach (kisi kisi in kişilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() &&  kisi.getYetki() == "admin")
                {
                    //admin sayfasına yönlendirir   ,

                    AdminSayfasi adminsayfasi = new AdminSayfasi(kişilerim , kitaplarim);
                    adminsayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                    
                }
                else if(kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    //uye sayfasına yönlendirir

                    UyeSayfasi uyesayfasi = new UyeSayfasi(kitaplarim);
                    uyesayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    
                }
               

            }
            if(!kontrol)
            {

                MessageBox.Show("Bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kişilerim.Add(new kisi(1, "Selçuk", "Salbaş",DateTime.Now, "viex", "viex06", "admin"));
            kişilerim.Add(new kisi(2, "Ferhat", "Simlik", DateTime.Now, "ferhat", "fero", "uye"));
            kişilerim.Add(new kisi(3, "Eren", "Akkaya", DateTime.Now, "eren", "ero", "uye"));
            kişilerim.Add(new kisi(4, "Samed", "Aydın", DateTime.Now, "samed", "samo", "uye"));
            kişilerim.Add(new kisi(5, "Aktuğ", "Çetin", DateTime.Now, "akdo", "123","admin"));


            kitaplarim.Add(new kitap(1, "İçimizdeki Şeytan","Sabahattin Ali", "Türkçe", "Yakamoz Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new kitap(2, "Tutunamayanlar","Oğuz Atay", "Türkçe", "Tdk Yayınları", "Roman", 60, 350, 2018));
            kitaplarim.Add(new kitap(56, "Suç ve Ceza","F.Dostoyevski", "Türkçe", "D&R Yayınları", "Roman", 700, 550, 2002));
            kitaplarim.Add(new kitap(89, "1984","G.Orwell", "İnglizce", "Okyanus Yayınları", "Roman", 100, 384, 2020));
            kitaplarim.Add(new kitap(34, "Beyaz Zambaklar Ülkesinde","G.Petrov" , "Türkçe", "Yakamoz Yayınları", "Roman", 150, 96, 2018));


        }
    }
}
