namespace Restoran_Adisyon_Otomasyonu
{
    partial class SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnAddSampleView = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearchSampleView = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlık";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(41, 181);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(963, 29);
            this.guna2Separator1.TabIndex = 4;
            // 
            // btnAddSampleView
            // 
            this.btnAddSampleView.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSampleView.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddSampleView.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnAddSampleView.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSampleView.Image")));
            this.btnAddSampleView.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddSampleView.ImageRotate = 0F;
            this.btnAddSampleView.ImageSize = new System.Drawing.Size(55, 55);
            this.btnAddSampleView.Location = new System.Drawing.Point(41, 95);
            this.btnAddSampleView.Name = "btnAddSampleView";
            this.btnAddSampleView.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnAddSampleView.Size = new System.Drawing.Size(64, 54);
            this.btnAddSampleView.TabIndex = 2;
            this.btnAddSampleView.UseTransparentBackground = true;
            this.btnAddSampleView.Click += new System.EventHandler(this.btnAddSampleView_Click);
            // 
            // txtSearchSampleView
            // 
            this.txtSearchSampleView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchSampleView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSampleView.DefaultText = "";
            this.txtSearchSampleView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchSampleView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchSampleView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSampleView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSampleView.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSampleView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchSampleView.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchSampleView.IconRight = global::Restoran_Adisyon_Otomasyonu.Properties.Resources.search;
            this.txtSearchSampleView.Location = new System.Drawing.Point(694, 112);
            this.txtSearchSampleView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSampleView.Name = "txtSearchSampleView";
            this.txtSearchSampleView.PasswordChar = '\0';
            this.txtSearchSampleView.PlaceholderText = "Ara";
            this.txtSearchSampleView.SelectedText = "";
            this.txtSearchSampleView.Size = new System.Drawing.Size(289, 37);
            this.txtSearchSampleView.TabIndex = 0;
            this.txtSearchSampleView.TextChanged += new System.EventHandler(this.txtSearchSampleView_TextChanged);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "RMS";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog1.Text = null;
            // 
            // SampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 648);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddSampleView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchSampleView);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SampleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtSearchSampleView;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ImageButton btnAddSampleView;
        public System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}