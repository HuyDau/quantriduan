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
    public partial class Quanlikhachhang : Form
    {
        public Quanlikhachhang()
        {
            InitializeComponent();
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            OnPlazahome frmOnplazaHome = new OnPlazahome();
            frmOnplazaHome.ShowDialog();
        }
        public void Hienthi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlKhachhang ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridViewKh.DataSource = ds.Tables[0];

        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO QlKhachhang(MaKH,Hoten,Diachi,SDT,Gmail) VALUES(@maKH,@hoten,@diachi,@sDT,@gmail)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maKH", tbMaKh.Text);
            cmd.Parameters.AddWithValue("@hoten", tbHotenKH.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
            cmd.Parameters.AddWithValue("@sDT", tbSDT.Text);
            cmd.Parameters.AddWithValue("@gmail", tbGmail.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnSuakh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE QlKhachhang SET Hoten=@hoten,Diachi=@diachi,SDT=@sDT,Gmail=@gmail WHERE MaKH=@maKH", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maKH", tbMaKh.Text);
            cmd.Parameters.AddWithValue("@hoten", tbHotenKH.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
            cmd.Parameters.AddWithValue("@sDT", tbSDT.Text);
            cmd.Parameters.AddWithValue("@gmail", tbGmail.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM QlKhachhang WHERE MaKH=@maKH", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maKH", tbMaKh.Text);
            cmd.Parameters.AddWithValue("@hoten", tbHotenKH.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachi.Text);
            cmd.Parameters.AddWithValue("@sDT", tbSDT.Text);
            cmd.Parameters.AddWithValue("@gmail", tbGmail.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlKhachhang WHERE MaKH=@maKH", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maKH", tbTimkiem.Text);
            cmd.Parameters.AddWithValue("@hoten", tbTimkiem.Text);
            cmd.Parameters.AddWithValue("@diachi", tbTimkiem.Text);
            cmd.Parameters.AddWithValue("@sDT", tbTimkiem.Text);
            cmd.Parameters.AddWithValue("@gmail", tbTimkiem.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridViewKh.DataSource = ds.Tables[0];
        }

        private void dataGridViewKh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlKhachhang ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridViewKh.DataSource = ds.Tables[0];
        }
    }
}
