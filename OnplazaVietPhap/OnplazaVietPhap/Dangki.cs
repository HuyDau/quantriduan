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
    public partial class Dangki : Form
    {
        public Dangki()
        {
            InitializeComponent();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            Form1 frmDangnhap = new Form1();
            frmDangnhap.Show();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-75A6E4B\SQLEXPRESS;Initial Catalog=Onplaza;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO users(username,password) VALUES (@user,@pass)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@user", txbUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txbPassword.Text);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Đăng kí thành công");
            conn.Close();
        }
    }
}
