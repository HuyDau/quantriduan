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
    public partial class Nhaphang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
        public Nhaphang()
        {
            InitializeComponent();
            conn.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void Loadcombobox()
        {
            var cmd = new SqlCommand("SELECT MaSP FROM QlSanpham", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaSp.DisplayMember = "MaSP";
            cbMaSp.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Nhaphang_Load(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void cbMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("SELECT * FROM QlSanpham WHERE MaSP = @maSP", conn);
            cmd.Parameters.AddWithValue("@maSP", cbMaSp.Text);
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbTenSP.DisplayMember = "TenSP";
            cbTenSP.DataSource = dt;
            dt.Load(dr);
            dr.Dispose();
            cbSoluong.DisplayMember = "SoLuong";
            cbSoluong.DataSource = dt;
            dt.Load(dr);
            dr.Dispose();
            cbGia.DisplayMember = "Gia";
            cbGia.DataSource = dt;
        }

        private void cbSoluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soluong;
            soluong = Convert.ToInt32(cbSoluong.Text);
            int soluongnhap;
            soluongnhap = Convert.ToInt32(tbSoluongnhap.Text);
            int tongsoluong;
            tongsoluong = soluong + soluongnhap;
            tbTongsoluong.Text = tongsoluong.ToString();
            int tongtiennhap;
            int gia = Convert.ToInt32(cbGia.Text);
            tongtiennhap = gia * soluongnhap;
            tbTongtien.Text = tongtiennhap.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE QlSanpham SET SoLuong=@soLuong WHERE MaSP=@maSP", conn);
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Qlphieunhap(maphieunhap,ngaynhap,masp,tensp,soluong,gia,tiennhap) VALUES(@maphieunhap,@ngaynhap,@masp,@tensp,@soluong,@gia,@tiennhap) ", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@maSP", cbMaSp.Text);
            cmd.Parameters.AddWithValue("@soLuong", tbTongsoluong.Text);

            cmd1.Parameters.AddWithValue("@maphieunhap", tbmaphieunhap.Text);
            cmd1.Parameters.AddWithValue("@ngaynhap", tbngaynhap.Text);
            cmd1.Parameters.AddWithValue("@masp", cbMaSp.Text);
            cmd1.Parameters.AddWithValue("@tensp", cbTenSP.Text);
            cmd1.Parameters.AddWithValue("@soluong", tbSoluongnhap.Text);
            cmd1.Parameters.AddWithValue("@gia", cbGia.Text);
            cmd1.Parameters.AddWithValue("@tiennhap", tbTongtien.Text);

            int i = cmd.ExecuteNonQuery();
            int J = cmd1.ExecuteNonQuery();
            conn.Close();

            Quanliphieunhap frmpn = new Quanliphieunhap();
            frmpn.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnPlazahome frmhome = new OnPlazahome();
            frmhome.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
