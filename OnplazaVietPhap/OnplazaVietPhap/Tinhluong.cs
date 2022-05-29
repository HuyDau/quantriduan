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
    public partial class Tinhluong : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
        public Tinhluong()
        {
            InitializeComponent();
            conn.Open();
        }
        void Loadcombobox()
        {
            var cmd = new SqlCommand("SELECT MaNV FROM QlNhanvien", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBoxmnv.DisplayMember = "MaNV";
            comboBoxmnv.DataSource = dt;
        }
        void Loadcombobox1()
        {
            var cmd1 = new SqlCommand("SELECT Hoten FROM QlNhanvien", conn);
            var dr1 = cmd1.ExecuteReader();
            var dt1 = new DataTable();
            dt1.Load(dr1);
            dr1.Dispose();
            comboBoxtnv.DisplayMember = "Hoten";
            comboBoxtnv.DataSource = dt1;
        }
        public void Tinhluong_FormClosing(object sender, EventArgs e)
        {
            conn.Close();
        }
        private void Tinhluong_Load(object sender, EventArgs e)
        {
            Loadcombobox();
            Loadcombobox1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int songaylam;
            songaylam = Convert.ToInt16(tbSongaylam.Text);
            int phat ;
            phat = Convert. ToInt32(tbphat.Text);
            int thuong;
            thuong = Convert.ToInt32(tbthuong.Text);
            int luong = songaylam*10*100000 + thuong - phat;
            tbLuong.Text = luong.ToString();
        }
        public void Hienthi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tinhluong ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Tinhluong(MaNV,Hoten,Thang,Songaylam,Luong) VALUES(@manv,@hoten,@thang,@songaylam,@luong)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@manv", comboBoxmnv.Text);
            cmd.Parameters.AddWithValue("@hoten", comboBoxtnv.Text);
            cmd.Parameters.AddWithValue("@thang", cbThang.Text);
            cmd.Parameters.AddWithValue("@songaylam", tbSongaylam.Text);
            cmd.Parameters.AddWithValue("@luong", tbLuong.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM Tinhluong WHERE MaNV=@manv AND Thang = @thang", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@manv", comboBoxmnv.Text);
            cmd.Parameters.AddWithValue("@hoten", comboBoxtnv.Text);
            cmd.Parameters.AddWithValue("@thang", cbThang.Text);
            cmd.Parameters.AddWithValue("@songaylam", tbSongaylam.Text);
            cmd.Parameters.AddWithValue("@luong", tbLuong.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tinhluong WHERE MaNV=@manv AND Thang = @thang", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@manv", comboBoxmnv.Text);
            cmd.Parameters.AddWithValue("@hoten", comboBoxtnv.Text);
            cmd.Parameters.AddWithValue("@thang", cbThang.Text);
            cmd.Parameters.AddWithValue("@songaylam", tbSongaylam.Text);
            cmd.Parameters.AddWithValue("@luong", tbLuong.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBoxtnv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxmnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("SELECT * FROM QlNhanvien WHERE MaNV = @maNV", conn);
            cmd.Parameters.AddWithValue("@maNV", comboBoxmnv.Text);
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            comboBoxtnv.DisplayMember = "TenNV";
            comboBoxtnv.DataSource = dt;
        }
    }
}
