using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnplazaVietPhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Dangnhap WHERE username=@user AND password=@pass", conn);

            cmd.Parameters.AddWithValue("@user", txbUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txbPassword.Text);

            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Đăng nhập thành công !");
                OnPlazahome frmHome = new OnPlazahome();
                frmHome.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
