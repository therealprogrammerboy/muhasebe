using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Genel_Muhasebe.UI.Admin;
using Genel_Muhasebe.UI.User;
using Genel_Muhasebe.DataBase;
using System.Data.SqlClient;

namespace Genel_Muhasebe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminGirisYap();
        }
        void AdminGirisYap()
        {
            if (checkBox1.Checked)
            {
                string kuladi = "", parola = "";
                SqlVeriTabniBag sqlVeriTabniBag = new SqlVeriTabniBag();
                sqlVeriTabniBag.VeritabaniOlustur1();
                string id = textBox1.Text, pwd = textBox2.Text;
                Listele();
                for (int i = 0; i < ListeAdmin.Count; i++)
                {
                    kuladi = ListeAdmin[i].GetId();
                    parola = ListeAdmin[i].GetPwd();
                }
                if (id == kuladi && pwd == parola)
                {
                    MainFrameAdmin frameAdmin = new MainFrameAdmin();
                    frameAdmin.Show();                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
            else
            {
                string kuladi = "", parola = "";
                string id = textBox1.Text, pwd = textBox2.Text;
                Listele();
                for (int i = 0; i < ListeAdmin.Count; i++)
                {
                    kuladi = ListeAdmin[i].GetId();
                    parola = ListeAdmin[i].GetPwd();
                }
                if (id == kuladi && pwd == parola)
                {
                    MainFrameAdmin frameAdmin = new MainFrameAdmin();
                    frameAdmin.Show();                   
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }

        }
        List<AdminKutuphane> ListeAdmin = new List<AdminKutuphane>();
        List<AdminKutuphane> Listele()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Server=.\\sqlexpress;Database=MYDATA;Integrated Security=true;");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from ADMIN_DATA", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    AdminKutuphane adminKutuphane = new AdminKutuphane();
                    adminKutuphane.SetId(sqlDataReader.GetString(0));
                    adminKutuphane.SetPwd(sqlDataReader.GetString(1));
                    ListeAdmin.Add(adminKutuphane);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            return ListeAdmin;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserGirisYap();
        }
        List<UserKutuphane> ListeUser = new List<UserKutuphane>();
        List<UserKutuphane> UserListele()
        {
            SqlConnection connection = new SqlConnection("Server=.\\sqlexpress;Database=MYDATA;Integrated Security=true;");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ID,PWD FROM USER_DATA WHERE ID='" + textBox1.Text + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserKutuphane userKutuphane = new UserKutuphane();
                userKutuphane.SetUserID(reader.GetString(0));
                userKutuphane.SetUserPWD(reader.GetString(1));
                ListeUser.Add(userKutuphane);
            }
            return ListeUser;
        }
        void UserGirisYap()
        {
            UserListele();
            string id = textBox1.Text, pwd = textBox2.Text, kuladi = "", sifre = "";
            for (int i = 0; i < ListeUser.Count; i++)
            {
                kuladi = ListeUser[i].GetUserID();
                sifre = ListeUser[i].GetUserPWD();
            }
            if (id == kuladi && pwd == sifre)
            {
                MainFrameUser frameUser = new MainFrameUser();
                frameUser.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girdiniz! ");
            }
        }

    }
}
