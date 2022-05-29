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
    public partial class Quanlinhanvien : Form
    {
        public Quanlinhanvien()
        {
            InitializeComponent();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            OnPlazahome frmOnplazaHome = new OnPlazahome();
            frmOnplazaHome.ShowDialog();
        }
        public void Hienthi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlNhanvien ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            datagridviewNhanvien.DataSource = ds.Tables[0];
        }
        private void btnThemNv_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO QlNhanvien(MaNv,Hoten,Diachi,SDT,Ngaysinh,CMND) VALUES(@maNV,@hoten,@diachi,@sDT,@ngaysinh,@cMND)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@hoten", tbHotenNV.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachiNv.Text);
            cmd.Parameters.AddWithValue("@sDT", tbSDTNv.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", tbNgaysinh.Text);
            cmd.Parameters.AddWithValue("@cMND", tbCMND.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE QlNhanvien SET Hoten=@hoten,Diachi=@diachi,SDT=@sDT,Ngaysinh=@ngaysinh,CMND=@cMND WHERE MaNV=@maNV", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@hoten", tbHotenNV.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachiNv.Text);
            cmd.Parameters.AddWithValue("@sDT", tbSDTNv.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", tbNgaysinh.Text);
            cmd.Parameters.AddWithValue("@cMND", tbCMND.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM QlNhanvien WHERE MaNV=@maNV", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@hoten", tbHotenNV.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachiNv.Text);
            cmd.Parameters.AddWithValue("@sDT", tbSDTNv.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", tbNgaysinh.Text);
            cmd.Parameters.AddWithValue("@cMND", tbCMND.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlNhanvien WHERE MaNV=@maNV", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maNv", tbTimkiem.Text);
            cmd.Parameters.AddWithValue("@hoten", tbHotenNV.Text);
            cmd.Parameters.AddWithValue("@diachi", tbDiachiNv.Text);
            cmd.Parameters.AddWithValue("@sDT", tbSDTNv.Text);
            cmd.Parameters.AddWithValue("@ngaysinh", tbNgaysinh.Text);
            cmd.Parameters.AddWithValue("@cMND", tbCMND.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            datagridviewNhanvien.DataSource = ds.Tables[0];
        }
    }
}
