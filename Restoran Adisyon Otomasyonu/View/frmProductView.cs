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

namespace Restoran_Adisyon_Otomasyonu.View
{
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string qry = "Select pID, pName, pPrice, CategoryID, c.catName from products p inner join category c on c.catID = P.CategoryID where pName like '%" + txtSearchSampleView.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCategoryID);
            lb.Items.Add(dgvCategory);
            MainClass.LoadData(qry, guna2DataGridView, lb);
        }

        public override void btnAddSampleView_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd();
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
                    frmProductAdd frm = new frmProductAdd();
                    frm.id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);
                    frm.cID = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvCategoryID"].Value);
                    frm.ShowDialog();
                    GetData();
                }
                // Silme işlemi
                if (guna2DataGridView.CurrentCell.OwningColumn.Name == "dgvDel")
                {
                    int id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);

                    string qry = "Delete from products where pID = @pID";
                    Hashtable ht = new Hashtable();
                    ht.Add("@pID", id);
                    MainClass.SQL(qry, ht);
                    GetData();
                }
            }
        }
    }
}
