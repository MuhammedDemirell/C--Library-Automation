using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.NewFolder1
{
    public class Kitap
    {
        public int kitapid;
        public string kitapIsim;
        public string kitapYazar;
        public string KitapDili;
        public string yayınEvi;
        public string tur;
        public int adet;
        public int SayfaSayisi;
        public int basimYili;
        public Kitap()
        {

        }
        public Kitap (int kitapid, string kitapIsim, string kitapYazar, string KitapDili, string yayınEvi, string tur, int adet, int SayfaSayisi, int basimYili)
            {
            this.kitapid = kitapid;
            this.kitapIsim = kitapIsim;
            this.kitapYazar = kitapYazar;
            this.KitapDili = KitapDili;
            this.yayınEvi = yayınEvi;
            this.tur = tur;
            this.adet = adet;
            this.SayfaSayisi = SayfaSayisi;
            this.basimYili = basimYili;

            }
        public void setkitapId(int kitapid)
        {
            this.kitapid = kitapid;
        }
        public int getKitapId()
        {
            return this.kitapid;
        }
        public void setkitapIsim(string kitapIsim)
        {
            this.kitapIsim = kitapIsim;
        }
        public string getKitapIsim()
        {
            return this.kitapIsim;
        }
        public void setkitapyazar(string kitapYazar)
        {
            this.kitapYazar = kitapYazar;
        }
        public string getitapyazar()
        {
            return this.kitapYazar;
        }
        public void setkitapdili(string KitapDili)
        {
            this.KitapDili = KitapDili;
        }
        public string getkitapdili()
        {
            return this.KitapDili;
        }
        public void setyayınevi(string yayınEvi)
        {
            this.yayınEvi = yayınEvi;
        }
        public string getyayınevi()
        {
            return this.yayınEvi;
        }
        public void setTur(string tur)
        {
            this.tur = tur;
        }
        public string getTur()
        {
            return this.tur;
        }
        public void setAdet(int adet)
        {
            this.adet = adet;
        }
        public int getAdet()
        {
            return this.adet;
        }
        public void setSayfasayisi(int SayfaSayisi)
        {
            this.SayfaSayisi = SayfaSayisi;
        }
        public int getSayfasayisi()
        {
            return this.SayfaSayisi;
        }
        public void setBasimYili(int basimYili)
        {
            this.basimYili = basimYili;
        }
        public int getBasimYili()
        {
            return this.basimYili;
        }

    }
}
