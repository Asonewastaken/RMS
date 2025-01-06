using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Adisyon_Otomasyonu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        

        /*private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtParola.Show();
        }*/

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnGirisYap_Click(this,EventArgs.Empty);
        }

        private void BtnCik_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?",
                                         "Çıkış Onayı",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txtKullaniciAdi.Text, txtParola.Text) == false)
            {
                guna2MessageDialog1.Show("Kullanıcı Adı veya Şifre Hatalı");
                return;
            }
            else
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
        }
    }
}
