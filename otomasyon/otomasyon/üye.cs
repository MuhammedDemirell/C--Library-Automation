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
    public partial class üye : Form
    {
        List<Kitap> kitaplarim;
        public üye(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void üye_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getBasimYili(), kitap.getAdet(), kitap.getitapyazar(), kitap.getkitapdili(), kitap.getkitapdili(), kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapIsim(), kitap.getSayfasayisi(), kitap.getTur(), kitap.getyayınevi());

            }
        }

        private void x1_Click(object sender, EventArgs e)
        {
            
            int hedefkitap = Convert.ToInt32(z1.Text);
            dataGridView2.Rows.Clear();
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getBasimYili() == hedefkitap)
                {
                    dataGridView2.Rows.Add(kitap.getBasimYili(), kitap.getAdet(), kitap.getitapyazar(), kitap.getkitapdili(), kitap.getkitapdili(), kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapIsim(), kitap.getSayfasayisi(), kitap.getTur(), kitap.getyayınevi());

                }

            }

        }

        private void x2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getBasimYili(), kitap.getAdet(), kitap.getitapyazar(), kitap.getkitapdili(), kitap.getkitapdili(), kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapIsim(), kitap.getSayfasayisi(), kitap.getTur(), kitap.getyayınevi());

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
