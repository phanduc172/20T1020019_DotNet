using _20T1020019.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20T1020019
{
    public partial class ChiTietSanPham : Form
    {
        public ChiTietSanPham()
        {
            InitializeComponent();
        }

        public void HienThiThongTinChiTiet(SanPham sanPham)
        {
            txtMaSanPham.Text = sanPham.maSanPham;
            txtTenSanPham.Text = sanPham.tenSanPham;
            dtpNgaySanXuat.Value = sanPham.ngaySanXuat;
            dtpNgayHetHan.Value = sanPham.ngayHetHan;
            txtGiaBan.Text = sanPham.giaBan.ToString();
            txtSoLuongNhap.Text = sanPham.soLuongNhap.ToString();
            picHinhDaiDien.ImageLocation = sanPham.hinhDaiDien;

        }

        private void picHinhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}
