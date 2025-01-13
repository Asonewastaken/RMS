using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Restoran_Adisyon_Otomasyonu.View
{
    public partial class frmKitchenView : Form
    {
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();

            string qry1 = @"SELECT * FROM tblMain WHERE status = 'Pending'";
            DataTable mainTable = ExecuteQuery(qry1);

            foreach (DataRow mainRow in mainTable.Rows)
            {
                FlowLayoutPanel orderPanel = CreateOrderPanel(mainRow);

                int mainID = Convert.ToInt32(mainRow["MainID"]);
                string qry2 = $@"SELECT p.pName, d.Qty 
                                 FROM tblDetails d
                                 INNER JOIN products p ON d.proID = p.PID
                                 WHERE d.MainID = {mainID}";
                DataTable detailsTable = ExecuteQuery(qry2);

                AddOrderDetails(orderPanel, detailsTable);
                flowLayoutPanel1.Controls.Add(orderPanel);
            }
        }

        private FlowLayoutPanel CreateOrderPanel(DataRow mainRow)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                AutoSize = true,
                Width = 400,
                FlowDirection = FlowDirection.TopDown,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            FlowLayoutPanel headerPanel = new FlowLayoutPanel
            {
                BackColor = Color.FromArgb(45, 23, 85),
                AutoSize = true,
                Width = 380,
                FlowDirection = FlowDirection.TopDown,
                Margin = new Padding(0)
            };

            // Sipariş Bilgileri
            headerPanel.Controls.Add(CreateLabel($"Masa : {mainRow["TableName"]}", Color.White));
            headerPanel.Controls.Add(CreateLabel($"Garson Adı : {mainRow["WaiterName"]}", Color.White));
            DateTime orderTime = Convert.ToDateTime(mainRow["aTime"]);
            headerPanel.Controls.Add(CreateLabel($"Sipariş Zamanı: {orderTime:HH:mm}", Color.White));
            headerPanel.Controls.Add(CreateLabel($"Sipariş Tipi : {mainRow["orderType"]}", Color.White));

            panel.Controls.Add(headerPanel);

            // Tamamlandı Butonu
            Guna.UI2.WinForms.Guna2Button completeButton = new Guna.UI2.WinForms.Guna2Button
            {
                AutoRoundedCorners = true,
                Size = new Size(100, 35),
                FillColor = Color.FromArgb(207, 36, 103),
                Margin = new Padding(60, 5, 3, 10),
                Text = "Tamamlandı",
                Tag = mainRow["MainID"]
            };
            completeButton.Click += CompleteOrder_Click;
            panel.Controls.Add(completeButton);

            return panel;
        }

        private Label CreateLabel(string text, Color color)
        {
            return new Label
            {
                Text = text,
                ForeColor = color,
                Margin = new Padding(10, 5, 3, 0),
                AutoSize = true
            };
        }

        private void AddOrderDetails(FlowLayoutPanel parentPanel, DataTable detailsTable)
        {
            if (detailsTable.Rows.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "Sipariş detayı bulunamadı.",
                    ForeColor = Color.Red,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true
                };
                parentPanel.Controls.Add(emptyLabel);
                return;
            }

            FlowLayoutPanel detailsPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                Width = 380,
                FlowDirection = FlowDirection.TopDown,
                Margin = new Padding(0)
            };

            for (int i = 0; i < detailsTable.Rows.Count; i++)
            {
                string productName = detailsTable.Rows[i]["pName"].ToString();
                string quantity = detailsTable.Rows[i]["Qty"].ToString();
                string text = $"{i + 1}. {productName} - {quantity}";

                Label detailLabel = new Label
                {
                    Text = text,
                    ForeColor = Color.Black,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true
                };

                detailsPanel.Controls.Add(detailLabel);
            }

            parentPanel.Controls.Add(detailsPanel);
        }

        private void CompleteOrder_Click(object sender, EventArgs e)
        {
            int mainID = Convert.ToInt32((sender as Guna.UI2.WinForms.Guna2Button).Tag);

            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

            if (guna2MessageDialog1.Show("Silmek istediğinize emin misiniz ?") == DialogResult.Yes)
            {
                string qry = @"UPDATE tblMain SET status = 'Tamamlandı' WHERE MainID = @MainID";
                Hashtable parameters = new Hashtable { { "@MainID", mainID } };

                if (MainClass.SQL(qry, parameters) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Başarıyla Kaydedildi");
                }

                GetOrders();
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
