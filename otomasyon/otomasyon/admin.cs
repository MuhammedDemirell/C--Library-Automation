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
    public partial class admin : Form
    {
        List<Kişi> kisilerim;
        List<Kitap> kitaplarim;
        public admin(List<Kişi> kisilerim,List<Kitap> kitaplarim)
        
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim=kitaplarim;
        }

        private void admin_Load(object sender, EventArgs e)
        {
          
            foreach (Kişi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(),kisi.getIsim(),kisi.getsoyIsim(),kisi.getOlusturmaTarihi(),kisi.getKullaniciAdi(),kisi.getSifre(),kisi.getYetki());
               
            }
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getBasimYili(),kitap.getAdet(),kitap.getitapyazar(),kitap.getkitapdili(),kitap.getkitapdili(),kitap.getKitapId(),kitap.getKitapIsim(),kitap.getKitapIsim(),kitap.getSayfasayisi(),kitap.getTur(),kitap.getyayınevi());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string isim, soyisim, kullaniciadi, şifre, yetki;
            string Olusturma;
            id = Convert.ToInt32(textBox1.Text);
            isim = textBox2.Text;
            soyisim = textBox3.Text;
            kullaniciadi = textBox4.Text;
            şifre = textBox5.Text;
            yetki = textBox6.Text;
            Olusturma = maskedTextBox1.Text;

            dataGridView1.Rows.Add(id, isim, soyisim, kullaniciadi, şifre, yetki, Olusturma);
            

    }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i=0; i<groupBox1.Controls.Count; i++)
            {
                if(groupBox1.Controls[i] is TextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            string isim, soyisim, kullaniciadi, şifre, yetki;
            string Olusturma;
            id = Convert.ToInt32(textBox1.Text);
            isim = textBox2.Text;
            soyisim = textBox3.Text;
            Olusturma = maskedTextBox1.Text;
            kullaniciadi = textBox4.Text;
            şifre = textBox5.Text;
            yetki = textBox6.Text;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, Olusturma,kullaniciadi, şifre, yetki, Olusturma);


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int kitapid = Convert.ToInt32(txt1.Text);
            string kitapIsim = txt2.Text;
            string kitapYazar = txt3.Text;
            string KitapDili = txt4.Text;
            string yayınEvi = txt5.Text;
            string tur = txt6.Text;
            int adet = Convert.ToInt32(txt7.Text);
            int SayfaSayisi = Convert.ToInt32(txt8.Text);
            int basimYili = Convert.ToInt32(txt9.Text);
            dataGridView2.Rows.Add(kitapid, kitapIsim, kitapYazar, KitapDili, yayınEvi, tur, adet, SayfaSayisi, basimYili);

        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i =0; i<groupBox2.Controls.Count; i++)
            {
                if(groupBox2.Controls[i] is TextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kitapid = Convert.ToInt32(txt1.Text);
            string kitapIsim = txt2.Text;
            string kitapYazar = txt3.Text;
            string KitapDili = txt4.Text;
            string yayınEvi = txt5.Text;
            string tur = txt6.Text;
            int adet = Convert.ToInt32(txt7.Text);
            int SayfaSayisi = Convert.ToInt32(txt8.Text);
            int basimYili = Convert.ToInt32(txt9.Text);
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapIsim, kitapYazar, KitapDili, yayınEvi, tur, adet, SayfaSayisi, basimYili);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Kişi hedefkişi = null;
            int secilenid = Convert.ToInt32(te1.Text);
            foreach (Kişi kisi in kisilerim)
            {
                if(kisi.getId()==secilenid)
                {
                    hedefkişi = kisi;
                    break;
                }



            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkişi.getId(), hedefkişi.getIsim(), hedefkişi.getsoyIsim(), hedefkişi.getOlusturmaTarihi(), hedefkişi.getKullaniciAdi(), hedefkişi.getSifre(), hedefkişi.getYetki());


        }

        private void bt2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(Kişi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getsoyIsim(), kisi.getOlusturmaTarihi(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Kitap kkitap = null;
            int hedefkitap = Convert.ToInt32(tee.Text);
            foreach (Kitap kitap in kitaplarim)
            {
                if(kitap.getKitapId()==hedefkitap)
                {
                    kkitap = kitap;
                    break;
                }
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(kkitap.getBasimYili(), kkitap.getAdet(), kkitap.getitapyazar(), kkitap.getkitapdili(), kkitap.getkitapdili(), kkitap.getKitapId(), kkitap.getKitapIsim(), kkitap.getKitapIsim(), kkitap.getSayfasayisi(), kkitap.getTur(), kkitap.getyayınevi());

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getBasimYili(), kitap.getAdet(), kitap.getitapyazar(), kitap.getkitapdili(), kitap.getkitapdili(), kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapIsim(), kitap.getSayfasayisi(), kitap.getTur(), kitap.getyayınevi());

            }
        }

        private void cık_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
