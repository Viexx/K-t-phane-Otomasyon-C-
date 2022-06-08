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
    public partial class UyeSayfasi : Form
    {
        List<kitap> kitaplarım;
        public UyeSayfasi(List<kitap> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarım = kitaplarım;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            
            foreach (kitap hedefkitap in kitaplarım)
            {
                dataGridView1.Rows.Add(hedefkitap.getkitapID(), hedefkitap.getkitapIsım(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayınEvi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfaSayisi());
            }

            txt_kitaparauyeID.Text = string.Empty;
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Başarılı bir şeklide çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_kitaparauye_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32(txt_kitaparauyeID.Text);
            kitap hedefkitap = null;

            foreach (kitap kitap in kitaplarım)
            {
                if(kitap.getkitapID()==kitapID)
                {
                    hedefkitap = kitap;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkitap.getkitapID(), hedefkitap.getkitapIsım(), hedefkitap.getkitapYazar(), hedefkitap.getkitapDili(), hedefkitap.getyayınEvi(), hedefkitap.gettur(), hedefkitap.getadet(), hedefkitap.getsayfaSayisi());

            
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach(kitap kitap in kitaplarım)
            {
                dataGridView1.Rows.Add(kitap.getkitapID(), kitap.getkitapIsım(), kitap.getkitapYazar(), kitap.getkitapDili(), kitap.getyayınEvi(), kitap.gettur(), kitap.getadet(), kitap.getsayfaSayisi());
            }
        }
    }
}
