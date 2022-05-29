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
    public partial class Quanlikho : Form
    {
        public Quanlikho()
        {
            InitializeComponent();
        }
        public void Hienthi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlSanpham ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridViewSP.DataSource = ds.Tables[0];
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE QlSanpham SET TenSP=@tenSP,NhaCC=@nhaCC,NgayNhap=@ngaynhap,SoLuong=@soluong, Gia=@gia WHERE MaSP=@maSP", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maSP", tbMaSP.Text);
            cmd.Parameters.AddWithValue("@tenSP", tbTenSp.Text);
            cmd.Parameters.AddWithValue("@nhaCC", tbNhaCC.Text);
            cmd.Parameters.AddWithValue("@ngayNhap", tbNgaynhap.Text);
            cmd.Parameters.AddWithValue("@soLuong", tbSoluong.Text);
            cmd.Parameters.AddWithValue("@gia", tbGia.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO QlSanpham(MaSP,TenSP,NhaCC,NgayNhap,SoLuong,Gia) VALUES(@maSP,@tenSP,@nhaCC,@ngayNhap,@soLuong,@gia)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maSP", tbMaSP.Text);
            cmd.Parameters.AddWithValue("@tenSP", tbTenSp.Text);
            cmd.Parameters.AddWithValue("@nhaCC", tbNhaCC.Text);
            cmd.Parameters.AddWithValue("@ngayNhap", tbNgaynhap.Text);
            cmd.Parameters.AddWithValue("@soLuong", tbSoluong.Text);
            cmd.Parameters.AddWithValue("@gia", tbGia.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM QlSanpham WHERE MaSP=@maSP", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maSP", tbMaSP.Text);
            cmd.Parameters.AddWithValue("@tenSP", tbTenSp.Text);
            cmd.Parameters.AddWithValue("@nhaCC", tbNhaCC.Text);
            cmd.Parameters.AddWithValue("@ngayNhap", tbNgaynhap.Text);
            cmd.Parameters.AddWithValue("@soLuong", tbSoluong.Text);
            cmd.Parameters.AddWithValue("@gia", tbGia.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            OnPlazahome frmOnplazahome = new OnPlazahome();
            frmOnplazahome.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlSanpham WHERE MaSP=@maSP", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maSP", tbTimkiem.Text);
            cmd.Parameters.AddWithValue("@tenSP", tbTenSp.Text);
            cmd.Parameters.AddWithValue("@nhaCC", tbNhaCC.Text);
            cmd.Parameters.AddWithValue("@ngayNhap", tbNgaynhap.Text);
            cmd.Parameters.AddWithValue("@soLuong", tbSoluong.Text);
            cmd.Parameters.AddWithValue("@gia", tbGia.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridViewSP.DataSource = ds.Tables[0];
        }
    }
}
