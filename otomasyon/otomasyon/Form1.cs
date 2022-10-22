using otomasyon.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class Form1 : Form
    {
        List<Kişi> kisilerim = new List<Kişi>();
        List<Kitap> kitaplarim = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty; 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kişi(1,"Enes","Bayram",DateTime.Now,"enes","1","üye"));
            kisilerim.Add(new Kişi(2, "Muhammed", "Demirel", DateTime.Now, "muhammed", "2", "admin"));
            kisilerim.Add(new Kişi(3, "Melih", "Demirel", DateTime.Now, "melih", "3", "üye"));
            kisilerim.Add(new Kişi(4, "Samet", "Demir", DateTime.Now, "samet", "4", "üye"));
            kitaplarim.Add(new Kitap(1,"Yalnızlık","muhammed","Türkçe","MHD","romantik",100,499,2022));
            kitaplarim.Add(new Kitap(1, "İhanet", "Samet", "Türkçe", "SD", "Psikoloji", 50, 239, 2021));
            kitaplarim.Add(new Kitap(1, "Anlaşmazlık", "Melih", "Türkçe", "MD", "Kurgu", 20, 394, 2022));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;
            Boolean kontrol = false;
            foreach(Kişi kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower()== kisi.getSifre() && kisi.getYetki()=="admin")
                {
                    admin Admin = new admin(kisilerim,kitaplarim);
                    Admin.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "üye")
                {
                    üye Üye = new üye(kitaplarim);
                    Üye.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                
            }
            if(!kontrol)
            {
                MessageBox.Show("Hatali giriş ", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
