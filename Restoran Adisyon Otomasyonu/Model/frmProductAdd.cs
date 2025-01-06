using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Adisyon_Otomasyonu.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;
        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id', catName 'name' from category";
            MainClass.CBFill(qry, cbCategory);

            if (cID > 0)
            {
                cbCategory.SelectedValue = cID;
            }

            if (id>0)
            {
                forUpdateLoadData();
            }
        }

        string filePath; //Kullanıcının seçtiği dosyanın tam dosya yolunu tutmak için kullanılan bir string değişkenidir.
        Byte[] imageByteArray; //Resim dosyasını bayt dizisi formatında depolamak için kullanılan bir byte[] değişkenidir.
        //Bu metod kullanıcının bilgisayarından resim dosyası çekme işlemini sağlar.
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg"; //Bu filtre sadece jpg, png dosyalarının çalışmasını sağlar.
            if (ofd.ShowDialog()==DialogResult.OK) //Bu kontrol yapısı kullanıcıya bir dosya seçim penceresi açar, seçerse ok döndürür.
            {
                filePath = ofd.FileName; //Kullanıcının seçtiği dosyanın tam dosya yolunu filePath değişkenine atar.
                txtImage.Image = new Bitmap(filePath);//Seçilen dosyayı bitmap nesnesine dönüştürerek kullanıcı arayüzündeki bir görüntüleme kontrolüne (txtImage) yükler.
            }
        }

        public override void btnKaydetSampleAdd_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) //Insert
            {
                qry = "Insert into products Values(@Name, @price, @cat, @img)";
            }
            else //Update
            {
                qry = "Update products Set pName = @Name, pPrice = @price, CategoryID = @cat, pImage = @img where pID = @id";
            }

            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtNameSampleAdd.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cbCategory.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Başarıyla Kaydedildi");
                id = 0;
                cID = 0;
                txtNameSampleAdd.Text = "";
                txtPrice.Text = "";
                cbCategory.SelectedIndex = 0;
                cbCategory.SelectedIndex = -1;
                txtImage.Image = Restoran_Adisyon_Otomasyonu.Properties.Resources.bag;
                txtNameSampleAdd.Focus();
            }
        }

        //Products tablosundaki bir ürünün bilgilerini alıp, frmProductView de kullanıcı arayüzüne yüklemeye 
        //çalıştığım metod.
        private void forUpdateLoadData()
        {
            string qry = @"Select * from products where pID = " +id+  "";
            SqlCommand cmd = new SqlCommand(qry,MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                txtNameSampleAdd.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray = imageArray;
                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }
    }
}
