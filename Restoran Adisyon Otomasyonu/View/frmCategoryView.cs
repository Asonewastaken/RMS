using Restoran_Adisyon_Otomasyonu.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace Restoran_Adisyon_Otomasyonu.View
{
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * from category where catName like '%" + txtSearchSampleView.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView, lb);
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAddSampleView_Click(object sender, EventArgs e)
        {
            frmCategoryAdd frm = new frmCategoryAdd();
            frm.ShowDialog();
            GetData();
        }

        public override void txtSearchSampleView_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView.CurrentCell != null && guna2DataGridView.CurrentRow != null)
            {
                // Düzenleme işlemi
                if (guna2DataGridView.CurrentCell.OwningColumn.Name == "dgvEdit")
                {
                    frmCategoryAdd frm = new frmCategoryAdd();
                    frm.id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);
                    frm.txtNameSampleAdd.Text = Convert.ToString(guna2DataGridView.CurrentRow.Cells["dgvName"].Value);
                    frm.ShowDialog();
                    GetData();
                }
                // Silme işlemi
                if (guna2DataGridView.CurrentCell.OwningColumn.Name == "dgvDel")
                {
                    int id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);

                    string qry = "Delete from category where catID = @catID";
                    Hashtable ht = new Hashtable();
                    ht.Add("@catID", id);
                    MainClass.SQL(qry, ht);
                    GetData();
                }
            }
        }
    }
}
