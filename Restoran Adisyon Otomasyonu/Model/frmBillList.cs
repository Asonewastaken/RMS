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

namespace Restoran_Adisyon_Otomasyonu.Model
{
    public partial class frmBillList : Form
    {
        public frmBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;  
        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"Select MainID, TableName, WaiterName, orderType, status, total from tblMain
                                       where status <> 'Pending'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvTable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);
            MainClass.LoadData(qry, guna2DataGridView, lb);
        }

        private void guna2DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void guna2DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView.CurrentCell != null && guna2DataGridView.CurrentRow != null)
            {
                // Düzenleme işlemi
                if (guna2DataGridView.CurrentCell.OwningColumn.Name == "dgvEdit")
                {
                    
                    MainID = Convert.ToInt32(guna2DataGridView.CurrentRow.Cells["dgvid"].Value);
                    this.Close();
                    
                }
                
            }
        }
    }
}
