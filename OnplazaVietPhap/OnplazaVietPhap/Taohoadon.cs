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
    public partial class Taohoadon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
        public Taohoadon()
        {
            InitializeComponent();
            conn.Open();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO QlHoadon(MaHD,MaNV,Hotennv,Ngaytao,Hotenkhach,SDT,Diachi,MaSP,TenSP,Soluong,Tongtien) VALUES(@mahd,@manv,@hotennv,@ngaytao,@hotenkhach,@sdt,@diachi,@masp,@tensp,@soluong,@tongtien)", conn);
            SqlCommand cmd1 = new SqlCommand("UPDATE QlSanpham SET SoLuong=@soluong WHERE MaSP=@maSP", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@mahd", tbMahd.Text);
            cmd.Parameters.AddWithValue("@manv", cbmanv.Text);
            cmd.Parameters.AddWithValue("@hotennv", cbtennv.Text);
            cmd.Parameters.AddWithValue("@ngaytao", tbNgaytao.Text);
            cmd.Parameters.AddWithValue("@hotenkhach", tbhotenkh.Text);
            cmd.Parameters.AddWithValue("@sdt", tbsdt.Text);
            cmd.Parameters.AddWithValue("@diachi", tbdiachi.Text);
            cmd.Parameters.AddWithValue("@masp", cbMasp.Text);
            cmd.Parameters.AddWithValue("@tensp", comboBoxsp.Text);
            cmd.Parameters.AddWithValue("@soluong", tbsoluong.Text);
            cmd.Parameters.AddWithValue("@tongtien", tbThanhtien.Text);

            cmd1.Parameters.AddWithValue("@maSP", cbMasp.Text) ;
            cmd1.Parameters.AddWithValue("@soluong", cbConlai.Text);

            int j = cmd1.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        void Loadcombobox()
        {
            
        }

        public void Taohoadon_FormClosing(object sender, EventArgs e)
        {
            conn.Close();
        }
        void Loadcomboboxnv()
        {
            var cmd1 = new SqlCommand("SELECT MaNV FROM QlNhanvien", conn);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cbmanv.DisplayMember = "MaNV";
            cbmanv.DataSource = dt1;
        }
        void Loadcomboboxtennv()
        {
            var cmd1 = new SqlCommand("SELECT Hoten FROM QlNhanvien", conn);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            cbtennv.DisplayMember = "Hoten";
            cbtennv.DataSource = dt1;
        }
        void Loadcomboboxsp()
        {
            var cmd2 = new SqlCommand("SELECT MaSP FROM QlSanpham", conn);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cbMasp.DisplayMember = "MaSP";
            cbMasp.DataSource = dt2;
        }
        void Loadcomboboxtsp()
        {
            var cmd2 = new SqlCommand("SELECT TenSP FROM QlSanpham WHERE MaSP = @maSP", conn);
            cmd2.Parameters.AddWithValue("@maSP", cbMasp.Text);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            comboBoxsp.DisplayMember = "TenSP";
            comboBoxsp.DataSource = dt2;
        }
        private void Taohoadon_Load(object sender, EventArgs e)
        {
            Loadcombobox();
            Loadcomboboxnv();
            Loadcomboboxtennv();
            Loadcomboboxsp();
            Loadcomboboxtsp();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void Hienthi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM QlHoadon ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tonkho;
            tonkho = Convert.ToInt16(cbtrongkho.Text);
            int soluong = Convert.ToInt16(tbsoluong.Text);
            int conlai = tonkho - soluong;
            int thanhtien;
            int gia;
            gia = Convert.ToInt32(cbgia.Text);
            thanhtien = gia * soluong;
            tbThanhtien.Text = thanhtien.ToString();
            cbConlai.Text = conlai.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Comboboxnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("SELECT * FROM QlNhanvien WHERE MaNV = @maNV", conn);
            cmd.Parameters.AddWithValue("@maNV", cbmanv.Text);
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbtennv.DisplayMember = "TenNV";
            cbtennv.DataSource = dt;
        }

        private void cbMasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("SELECT * FROM QlSanpham WHERE MaSP = @maSP", conn);
            cmd.Parameters.AddWithValue("@maSP", cbMasp.Text);
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBoxsp.DisplayMember = "TenSP";
            comboBoxsp.DataSource = dt;
            cbtrongkho.DisplayMember = "SoLuong";
            cbtrongkho.DataSource = dt;
            cbgia.DisplayMember = "Gia";
            cbgia.DataSource = dt;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
