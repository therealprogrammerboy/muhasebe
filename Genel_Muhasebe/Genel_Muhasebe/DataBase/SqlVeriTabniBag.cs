using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Genel_Muhasebe.DataBase
{
    public class SqlVeriTabniBag
    {
        public void VeritabaniOlustur1()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Server=.\\sqlexpress;Database=master;Integrated Security=true;");
                connection.Open();
                SqlCommand command = new SqlCommand("USE master CREATE DATABASE MYDATA ", connection);
                command.ExecuteNonQuery();
                SqlCommand sqlCommand=new SqlCommand("USE MYDATA CREATE TABLE ADMIN_DATA(ID NVARCHAR(5),PWD NVARCHAR(5)) CREATE TABLE USER_DATA(ID NVARCHAR(10),PWD NVARCHAR(10)) INSERT INTO ADMIN_DATA(ID,PWD) VALUES('ADMIN','ADMIN') ", connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.ToString());
            }
            
        }

    }
}
