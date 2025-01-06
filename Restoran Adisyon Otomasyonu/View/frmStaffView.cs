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
    public partial class frmStaffView : SampleView
    {
        public frmStaffView()
        {
            InitializeComponent();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string qry = "Select * from staff where sName like '%" + txtSearchSampleView.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);
            MainClass.LoadData(qry, guna2DataGridView, lb);
        }

        public override void btnAddSampleView_Click(object sender, EventArgs e)
        {
            frmStaffAdd frm = new frmStaffAdd();
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
                    frmStaffAdd frm = new frmStaffAdd();
                    frm.id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);
                    frm.txtNameSampleAdd.Text = Convert.ToString(guna2DataGridView.CurrentRow.Cells["dgvName"].Value);
                    frm.txtPhoneStaff.Text = Convert.ToString(guna2DataGridView.CurrentRow.Cells["dgvPhone"].Value);
                    frm.cbRoleStaff.Text = Convert.ToString(guna2DataGridView.CurrentRow.Cells["dgvRole"].Value);
                    frm.ShowDialog();
                    GetData();
                }
                // Silme işlemi
                if (guna2DataGridView.CurrentCell.OwningColumn.Name == "dgvDel")
                {
                    int id = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);

                    string qry = "Delete from staff where staffID = @staffID";
                    Hashtable ht = new Hashtable();
                    ht.Add("@staffID", id);
                    MainClass.SQL(qry, ht);
                    GetData();
                }
            }
        }
    }
}
