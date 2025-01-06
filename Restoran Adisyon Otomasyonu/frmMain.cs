using Restoran_Adisyon_Otomasyonu.Model;
using Restoran_Adisyon_Otomasyonu.View;
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
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
        }

        public void AddControl(Form f)
        {
            CenterPanel.Controls.Clear();  
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControl(new frmHome());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AddControl(new frmCategoryView());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControl(new frmTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControl(new frmStaffView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AddControl(new frmProductView());
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            frmPOS frmPOS = new frmPOS();
            frmPOS.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControl(new frmKitchenView());
        }
    }
}
