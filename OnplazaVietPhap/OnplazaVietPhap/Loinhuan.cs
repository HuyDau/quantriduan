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
    public partial class Loinhuan : Form
    {
        public Loinhuan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int doanhthu;
            doanhthu = Convert.ToInt32(tbdoanhthu.Text);
            int luongnv;
            luongnv = Convert.ToInt32(tbluongnv.Text);
            int chiphi ;
            chiphi= Convert.ToInt32(tbchiphi.Text);
            int thunhap = doanhthu - luongnv - chiphi;
            tbthunhap.Text = thunhap.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnPlazahome frmhome = new OnPlazahome();
            frmhome.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Loinhuan(doanhthu,luongnv,thang,chiphi,thunhap) VALUES(@doanhthu,@luongnv,@thang,@chiphi,@thunhap)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@doanhthu", tbdoanhthu.Text);
            cmd.Parameters.AddWithValue("@luongnv", tbluongnv.Text);
            cmd.Parameters.AddWithValue("@thang", cbthang.Text);
            cmd.Parameters.AddWithValue("@chiphi", tbchiphi.Text);
            cmd.Parameters.AddWithValue("@thunhap", tbthunhap.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            Hienthi();
        
        }
        public void Hienthi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Loinhuan ", conn);

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Loinhuan WHERE thang=@thang", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@thang", cbthang.Text);

            int i = cmd.ExecuteNonQuery();
            conn.Close();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
