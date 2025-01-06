using System;
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
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        // Bu bir etkinlik tanımlamasıdır. Kullanıcı kontrolünde (ucProduct) belirli bir olay meydana geldiğinde (örneğin, bir ürün seçildiğinde) tetiklenir.
        public event EventHandler onSelect = null;
        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, EventArgs.Empty); // Olay tetikleniyor
        }

        //Parametrelerim
        public int id { get; set; }
        public string PPrice { get; set; }
        public string PCategory { get; set; }


        public string PName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

       
    }
}
