using _20T1020019.Model;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Forms;

namespace _20T1020019
{
    public partial class FormSanPham : Form
    {
        string fileName = "20t10200219.json";
        SanPham sanPham;
        List<SanPham> danhSachSanPham = new List<SanPham>();
        public FormSanPham()
        {
            InitializeComponent();
            LoadDataFromJsonFile();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sanpham = new SanPham
            {
                maSanPham = txtMaSanPham.Text,
                tenSanPham = txtTenSanPham.Text,
                ngaySanXuat = dtpNgaySanXuat.Value,
                ngayHetHan = dtpNgayHetHan.Value,
                giaBan = long.Parse(txtGiaBan.Text),
                soLuongNhap = long.Parse(txtSoLuongNhap.Text),
                hinhDaiDien = picHinhDaiDien.ImageLocation
            };

            List<SanPham> danhSachSanPham;

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                danhSachSanPham = JsonConvert.DeserializeObject<List<SanPham>>(json);
            }
            else
            {
                danhSachSanPham = new List<SanPham>();
            }
            danhSachSanPham.Add(sanpham);
            string newJson = JsonConvert.SerializeObject(danhSachSanPham);
            File.WriteAllText(fileName, newJson);
            MessageBox.Show("Đã thêm sản phẩm thành công", "Thông báo");
            //Làm mới ds sau khi thêm sản phẩm
            LoadDataFromJsonFile();
        }



        private void picHinhDaiDien_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog()
            {
                Title = "Chọn hình đại diện",
                Filter = "File ảnh | *.png; *.jpg;*.jpeg"
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var fileDaiDien = openDialog.FileName;
                picHinhDaiDien.Load(fileDaiDien);
            }
        }

        private void dtpNgaySanXuat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataFromJsonFile()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string json = File.ReadAllText(fileName);
                    List<SanPham> danhSachSanPham = JsonConvert.DeserializeObject<List<SanPham>>(json);
                    sanPhamBindingSource.DataSource = danhSachSanPham;
                    grdviewDanhSach.DataSource = sanPhamBindingSource;
                }
                else
                {
                    MessageBox.Show("Tệp JSON không tồn tại.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc hoặc xử lý dữ liệu từ tệp JSON: " + ex.Message, "Lỗi");
            }
        }

        private void grdviewDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int selectedIndex = e.RowIndex;
                SanPham selectedSanPham = (SanPham)sanPhamBindingSource.List[selectedIndex];

                ChiTietSanPham chiTietForm = new ChiTietSanPham();
                chiTietForm.HienThiThongTinChiTiet(selectedSanPham);
                chiTietForm.ShowDialog();

            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = grdviewDanhSach.Rows[e.RowIndex];

                string maSanPham = selectedRow.Cells["maSanPhamDataGridViewTextBoxColumn"].Value.ToString();
                string tenSanPham = selectedRow.Cells["tenSanPhamDataGridViewTextBoxColumn"].Value.ToString();
                DateTime ngaySanXuat = Convert.ToDateTime(selectedRow.Cells["ngaySanXuatDataGridViewTextBoxColumn"].Value);
                DateTime ngayHetHan = Convert.ToDateTime(selectedRow.Cells["ngayHetHanDataGridViewTextBoxColumn"].Value);
                long giaBan = Convert.ToInt64(selectedRow.Cells["giaBanDataGridViewTextBoxColumn"].Value);
                long soLuongNhap = Convert.ToInt64(selectedRow.Cells["soLuongNhapDataGridViewTextBoxColumn"].Value);
                string hinhDaiDien = selectedRow.Cells["hinhDaiDienDataGridViewTextBoxColumn"].Value.ToString();

                txtMaSanPham.Text = maSanPham;
                txtTenSanPham.Text = tenSanPham;
                dtpNgaySanXuat.Value = ngaySanXuat;
                dtpNgayHetHan.Value = ngayHetHan;
                txtGiaBan.Text = giaBan.ToString();
                txtSoLuongNhap.Text = soLuongNhap.ToString();
                picHinhDaiDien.ImageLocation = hinhDaiDien;
            }

        }


        private void FormSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sanPhamBindingSource.RemoveCurrent();
            }   
        }

    }
}