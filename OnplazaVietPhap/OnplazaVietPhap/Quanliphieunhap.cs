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
    public partial class Quanliphieunhap : Form
    {
        public Quanliphieunhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Qlphieunhap ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Qlphieunhap WHERE ngaynhap=@ngaynhap", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@ngaynhap", tbtimkiem.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
