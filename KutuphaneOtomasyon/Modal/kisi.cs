using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Modal
{
    public class kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public string KullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }


        public kisi()
        {

        }

        public kisi(int id, string isim,string soyisim,DateTime olusturmaTarih,string   kullaniciadi,string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarih = olusturmaTarih;
            this.KullaniciAdi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;
        }


        public void setId(int id )
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getIsım()
        {
            return this.isim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getSoyisim()
        {
            return this.soyisim;
        }
        public void setKullaniciAdi(string kullaniciadi)
        {
            this.KullaniciAdi = kullaniciadi;
        }
        public string getKullaniciAdi()
        {
            return this.KullaniciAdi;
        }
        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getSifre()
        {
            return this.sifre;
        }
        public void setYetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getYetki()
        {
            return this.yetki;
        }

        public void setOlusturmatarih(DateTime olusturmatarih)
        {
            this.olusturmaTarih = olusturmatarih;
        }
        public DateTime getOlusturmatarih()
        {
            return this.olusturmaTarih;
        }

        public override string ToString()
        {
            return "İsim + Soyisim :" + this.isim + " " + this.soyisim; 
        }
    }
}
