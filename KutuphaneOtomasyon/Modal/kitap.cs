using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Modal
{
    public class kitap
    {
        public int kitapId { get; set; }
        public string kitapIsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYili { get; set; }

        public kitap()
        {

        }

        public kitap(int kitapid, string kitapisim,string kitapyazar, string kitapdili, string yayinevi, string tur, int adet, int sayfasayisi, int basimyili)
        {
            this.kitapId = kitapid;
            this.kitapIsim = kitapisim;
            this.kitapYazar = kitapyazar;
            this.kitapDili = kitapdili;
            this.yayinEvi = yayinevi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayisi = sayfasayisi;
            this.basimYili = basimyili;

        }

        public int getkitapID()
        {
            return this.kitapId;
        }
        public string getkitapIsım()
        {
            return this.kitapIsim;
        }
        public string getkitapYazar()
        {
            return this.kitapYazar;
        }
        public string getkitapDili()
        {
            return this.kitapDili;
        }
        public string getyayınEvi()
        {
            return this.yayinEvi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfaSayisi()
        {
            return this.sayfaSayisi;
        }
        public int getbasımYili()
        {
            return this.basimYili;
        }


    }
}
