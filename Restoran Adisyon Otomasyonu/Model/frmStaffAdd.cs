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
    public partial class frmStaffAdd : SampleAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void frmStaffAdd_Load(object sender, EventArgs e)
        {

        }

        public override void btnKaydetSampleAdd_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into staff Values(@Name, @phone, @role)";
            }
            else
            {
                qry = "Update staff Set sName = @Name, sPhone = @phone, sRole = @role where staffID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtNameSampleAdd.Text);
            ht.Add("@phone", txtPhoneStaff.Text);
            ht.Add("@role", cbRoleStaff.Text);


            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Başarıyla Kaydedildi");
                id = 0;
                txtNameSampleAdd.Text = "";
                txtPhoneStaff.Text = "";
                cbRoleStaff.SelectedIndex = -1;
                txtNameSampleAdd.Focus();
            }
        }
    }
}
