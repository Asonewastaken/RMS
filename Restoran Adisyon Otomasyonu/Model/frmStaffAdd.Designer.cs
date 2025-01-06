namespace Restoran_Adisyon_Otomasyonu.Model
{
    partial class frmStaffAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPhoneStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRoleStaff = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Size = new System.Drawing.Size(181, 38);
            this.lblBaslik.Text = "Personel Ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restoran_Adisyon_Otomasyonu.Properties.Resources.Personal1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(83, 204);
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneStaff.DefaultText = "";
            this.txtPhoneStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneStaff.Location = new System.Drawing.Point(430, 253);
            this.txtPhoneStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.PasswordChar = '\0';
            this.txtPhoneStaff.PlaceholderText = "";
            this.txtPhoneStaff.SelectedText = "";
            this.txtPhoneStaff.Size = new System.Drawing.Size(289, 48);
            this.txtPhoneStaff.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(424, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol";
            // 
            // cbRoleStaff
            // 
            this.cbRoleStaff.BackColor = System.Drawing.Color.Transparent;
            this.cbRoleStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoleStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoleStaff.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoleStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoleStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRoleStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRoleStaff.ItemHeight = 30;
            this.cbRoleStaff.Items.AddRange(new object[] {
            "Kasiyer",
            "Garson",
            "Komi",
            "Temizlik Görevlisi",
            "Müdür",
            "Diğer"});
            this.cbRoleStaff.Location = new System.Drawing.Point(89, 369);
            this.cbRoleStaff.Name = "cbRoleStaff";
            this.cbRoleStaff.Size = new System.Drawing.Size(289, 36);
            this.cbRoleStaff.TabIndex = 5;
            // 
            // frmStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 563);
            this.Controls.Add(this.cbRoleStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneStaff);
            this.Controls.Add(this.label1);
            this.Name = "frmStaffAdd";
            this.Text = "frmStaffAdd";
            this.Load += new System.EventHandler(this.frmStaffAdd_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPhoneStaff, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbRoleStaff, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtPhoneStaff;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2ComboBox cbRoleStaff;
    }
}