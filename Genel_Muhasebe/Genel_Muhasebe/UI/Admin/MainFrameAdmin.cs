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

namespace Genel_Muhasebe.UI.Admin
{
    public partial class MainFrameAdmin : Form
    {
        public MainFrameAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text, pwd = textBox2.Text;
            SqlConnection connection = new SqlConnection("Server=.\\sqlexpress;Database=MYDATA;Integrated Security=true;");
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO USER_DATA(ID,PWD) VALUES('" + id + "','" + pwd + "')", connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı Başarı İle Eklendi !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text, pwd = textBox2.Text;
            SqlConnection connection = new SqlConnection("Server=.\\sqlexpress;Database=MYDATA;Integrated Security=true;");
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM USER_DATA WHERE ID='"+id+"'", connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı Başarı İle Silindi !");
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            SqlConnection connection = new SqlConnection("Server=.\\sqlexpress;Database=master;Integrated Security=true;");
            SqlCommand sqlCommand1 = new SqlCommand("use master", connection);
            SqlCommand sqlCommand2 = new SqlCommand("drop database MYDATA", connection);
            connection.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlCommand2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Veri Tabanı Başarı İle Silindi !");
        }
    }
}
