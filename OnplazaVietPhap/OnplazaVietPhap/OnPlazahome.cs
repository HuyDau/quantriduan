using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnplazaVietPhap
{
    public partial class OnPlazahome : Form
    {
        public OnPlazahome()
        {
            InitializeComponent();
        }

        private void trởLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmForm = new Form1();
            frmForm.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlinhanvien frmQlnhanvien = new Quanlinhanvien();
            frmQlnhanvien.ShowDialog();
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlikhachhang frmQuanlikhachhang = new Quanlikhachhang();
            frmQuanlikhachhang.Show();
        }

        private void quảnLíKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlikho frmQlKho = new Quanlikho();
            frmQlKho.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao frmBaocao = new BaoCao();
            frmBaocao.Show();
        }

        private void quảnLíBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taohoadon frmtaohoadon = new Taohoadon();
            frmtaohoadon.Show();
        }

        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tinhluong frmtl = new Tinhluong();
            frmtl.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taohoadon frmthd = new Taohoadon();
            frmthd.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nhaphang frmNhaphang = new Nhaphang();
            frmNhaphang.Show();
        }

        private void OnPlazahome_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doanhthu frmdoanhthu = new Doanhthu();
            frmdoanhthu.Show();
        }

        private void lợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loinhuan frmloinhuan = new Loinhuan();
            frmloinhuan.Show();
        }

        private void quảnLíPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanliphieunhap frmpn = new Quanliphieunhap();
            frmpn.Show();
        }
    }
}
