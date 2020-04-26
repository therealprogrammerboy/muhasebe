using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Satış İşlemi")
            {
                MessageBox.Show("satış");
            }
            else if (comboBox1.Text== "Alış İşlemi")
            {
                MessageBox.Show("Alış");
            }
            else if (comboBox1.Text== "Çek İşlemi")
            {
                MessageBox.Show("Çek");
            }
            else if (comboBox1.Text== "Rapor Çıkar")
            {
                MessageBox.Show("Rapor");
            }
            else
            {
                MessageBox.Show("Seçim Yapmadın !");
            }
        }
    }
}
