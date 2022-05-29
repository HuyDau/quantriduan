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
    public partial class Thongke : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-VH8DL0RG\SQLEXPRESS;Initial Catalog=OnplazaVietPhap;Integrated Security=True");
        public Thongke()
        {
            InitializeComponent();
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("SELECT SUM(Tongtien) FROM QlHoadon", conn);
            var dr = cmd.ExecuteReader();

            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbDoanhthu.DisplayMember = "SUM(Tongtien)";
            cbDoanhthu.DataSource = dt;
        }
    }
}
