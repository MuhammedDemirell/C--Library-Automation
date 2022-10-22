using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.NewFolder1
{
  public  class Kişi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }

        public Kişi(int id , string isim , string soyisim , DateTime olusturmaTarihi , string kullaniciAdi , string sifre , string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarihi = olusturmaTarihi;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
        }
        public Kişi()
        {

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
        public string getIsim()
        {
            return this.isim;
        }
        public void setsoyIsim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getsoyIsim()
        {
            return this.soyisim;
        }
        public void setOlusturmaTarihi(DateTime olusturmaTarihi)
        {
            this.olusturmaTarihi = olusturmaTarihi;
        }
        public DateTime getOlusturmaTarihi()
        {
            return this.olusturmaTarihi;
        }

        public void setKullaniciAdi(string kullaniciadi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }
        public string getKullaniciAdi()
        {
            return this.kullaniciAdi;
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
        public override string ToString()
        {
            return "isim  - " + "soyisim" + this.isim + " " + this.soyisim;
         }

    }
}
