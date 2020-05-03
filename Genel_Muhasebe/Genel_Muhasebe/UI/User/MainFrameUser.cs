using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Genel_Muhasebe.UI.User
{
    public partial class MainFrameUser : Form
    {
        public MainFrameUser()
        {
            InitializeComponent();
        }
        private void MainFrameUser_Load(object sender, EventArgs e) { 
            
        }
        #region Alisİslemleri
        Label label = new Label
        {
            Text = "Ürün İsmi Giriniz : ",
            Top = 11,
            Left = 10,
            Width = 100
        };
        TextBox txtUrunismi = new TextBox
        {
            Top = 10,
            Left = 110,
            Width = 200
        };
        Label label3 = new Label
        {
            Text = "Ürün Fiyatı Giriniz : ",
            Top = 40,
            Left = 10,
            Width = 100
        };
        TextBox txtFiyat = new TextBox
        {
            Top = 40,
            Left = 110,
            Width = 200
        };
        Label label4 = new Label
        {
            Text = "Ürün Adedi Giriniz : ",
            Top = 69,
            Left = 10,
            Width = 100
        };
        TextBox txtMiktar = new TextBox
        {
            Top = 69,
            Left = 110,
            Width = 200
        };
        Button btnAlıs = new Button
        {
            Text = "İşlemi Tamamla",
            Top = 20,
            Left = 350,
            Height = 70,
            Width = 100

        };
        void btnAlıs_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunismi.Text, urunFiyati = txtFiyat.Text, urunMiktari = txtMiktar.Text;
            SqlConnection connection = new SqlConnection("Server=.\\sqlexpress;Database=MYDATA;Integrated Security=true;");
            SqlCommand sqlCommand = new SqlCommand("insert into URUNLER(urun_adi,urun_fiyati,urun_adedi) values('" + urunAdi + "','" + urunFiyati + "','" + urunMiktari + "')", connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün Başarıyla Eklenmiştir !");
        }
        #endregion Alisİslemleri
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            panel3.Controls.Add(label);           
            panel3.Controls.Add(txtUrunismi);           
            panel3.Controls.Add(label3);           
            panel3.Controls.Add(txtFiyat);            
            panel3.Controls.Add(label4);           
            panel3.Controls.Add(txtMiktar);            
            panel3.Controls.Add(btnAlıs);
            btnAlıs.Click+=btnAlıs_Click;
        }
        
    }
}
