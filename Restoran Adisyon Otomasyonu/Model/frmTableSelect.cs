﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Adisyon_Otomasyonu.Model
{
    public partial class frmTableSelect : Form
    {
        public frmTableSelect()
        {
            InitializeComponent();
        }
        public string TableName;

        private void frmTableSelect_Load(object sender, EventArgs e)
        {
            string qry = "Select * from tables";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                b.Text = row["tname"].ToString();
                b.Width = 150;
                b.Height = 50;
                b.FillColor = Color.FromArgb(207, 36, 103);
                b.HoverState.FillColor = Color.FromArgb(45, 23, 85);
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            TableName = (sender as Guna.UI2.WinForms.Guna2Button).Text.ToString();
            this.Close();
        }

    }
}