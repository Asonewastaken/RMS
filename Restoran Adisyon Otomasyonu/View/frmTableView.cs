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
    public partial class frmTableView : SampleView
    {
        public frmTableView()
        {
            InitializeComponent();
        }

        private void frmTableView_Load(object sender, EventArgs e)
        {

            GetData();
        }

        public void GetData()
        {
            string qry = "Select * from tables where tname like '%" + txtSearchSampleView.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, guna2DataGridView, lb);
        }

        public override void btnAddSampleView_Click(object sender, EventArgs e)
        {
            frmTableAdd frm = new frmTableAdd();
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
                    frmTableAdd frm = new frmTableAdd();
                    frm.id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);
                    frm.txtNameSampleAdd.Text = Convert.ToString(guna2DataGridView.CurrentRow.Cells["dgvName"].Value);
                    frm.ShowDialog();
                    GetData();
                }
                // Silme işlemi
                if (guna2DataGridView.CurrentCell.OwningColumn.Name == "dgvDel")
                {
                    int id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);

                    string qry = "Delete from tables where tid = @tid";
                    Hashtable ht = new Hashtable();
                    ht.Add("@tid", id);
                    MainClass.SQL(qry, ht);
                    GetData();
                }
            }
        }
    }
}
