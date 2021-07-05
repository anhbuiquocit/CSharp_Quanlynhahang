using BTLW_BuiQuocAnh.Controller;
using BTLW_BuiQuocAnh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLW_BuiQuocAnh.View
{
    public partial class FrmHoadonxuat : Form
    {
        BALController bal = new BALController();
        String mahd;
        double thanhTien = 0;
        double VAT = 0;
        double tongTien = 0;
        List<ChiTietHoaDon> listChitiethoadon = new List<ChiTietHoaDon>();
        public FrmHoadonxuat()
        {
            InitializeComponent();
        }
        public FrmHoadonxuat(String mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
            listChitiethoadon = bal.getChiTietHoaDon(mahd);
            if(listChitiethoadon.Count > 0)
                lblTennv.Text = listChitiethoadon[0].HoaDon.nguoiDung.hoTen.ToString();
            foreach(ChiTietHoaDon ct in listChitiethoadon)
            {
                thanhTien += ct.SanPham.giaBan * ct.SoLuong;
            }
            VAT = 0.1 * thanhTien;
            tongTien = VAT + thanhTien;
        }

        private void FrmHoadonxuat_Load(object sender, EventArgs e)
        {
            dgvHoadon.DataSource = bal.getListChitiethoadonByMahd(mahd);
            lblThanhtien.Text = thanhTien.ToString();
            lblVat.Text = VAT.ToString();
            lblTongtien.Text = tongTien.ToString();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn in hóa đơn không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                // khởi tạo excel
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // khởi tạo workbook
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // khởi tạo worksheet
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;//kích hoạt trang
                app.Visible = true;
                // đổ dữ liệu
                worksheet.Cells[1, 1] = "HÓA ĐƠN BÁN HÀNG";
                worksheet.Cells[2, 1] = "Mã Hóa đơn: " + label3.Text;
                worksheet.Cells[2, 4] = "tel: " + label8.Text;
                worksheet.Cells[3, 1] = "Địa chỉ: " + label5.Text;
                worksheet.Cells[3, 4] = "Giò mở cửa: " + label11.Text;
                worksheet.Cells[4, 1] = "Người thu: " + lblTennv.Text;
                worksheet.Cells[4, 4] = "Giò đóng cửa: " + label10.Text;
                worksheet.Cells[6, 1] = "TT";
                worksheet.Cells[6, 2] = "Mã CTHD";
                worksheet.Cells[6, 3] = "Mã hóa đơn";
                worksheet.Cells[6, 4] = "Tên sản phẩm";
                worksheet.Cells[6, 5] = "Số lượng";
                worksheet.Cells[6, 6] = "Đơn giá";

                worksheet.Cells[6, 5] = "Thành tiền";
                int a = dgvHoadon.Rows.Count;
                int dem = 0;
                for (int i = 0; i < a - 1; i++)
                {
                    worksheet.Cells[i + 7, 1] = i + 1;
                    worksheet.Cells[i + 7, 2] = dgvHoadon.Rows[i].Cells[1].Value.ToString();
                    worksheet.Cells[i + 7, 3] = dgvHoadon.Rows[i].Cells[2].Value.ToString();
                    worksheet.Cells[i + 7, 4] = dgvHoadon.Rows[i].Cells[3].Value.ToString();
                    worksheet.Cells[i + 7, 5] = dgvHoadon.Rows[i].Cells[4].Value.ToString();
                    worksheet.Cells[i + 7, 6] = dgvHoadon.Rows[i].Cells[5].Value.ToString();
                    dem++;
                }
                worksheet.Cells[dem + 7, 2] = "Thành Tiền: ";
                worksheet.Cells[dem + 7, 5] = lblThanhtien.Text + " Đ";
                worksheet.Cells[dem + 8, 2] = "Thuế: ";
                worksheet.Cells[dem + 8, 5] = lblVat.Text + " Đ";
                worksheet.Cells[dem +9, 2] = "Tổng Tiền: ";
                worksheet.Cells[dem + 9, 5] = lblTongtien.Text + " Đ";

                worksheet.Range["A1"].ColumnWidth = 10;
                worksheet.Range["B1"].ColumnWidth = 25;
                worksheet.Range["C1"].ColumnWidth = 15;
                worksheet.Range["D1"].ColumnWidth = 25;
                worksheet.Range["E1"].ColumnWidth = 25;
                worksheet.Range["F1"].ColumnWidth = 25;
                worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
                worksheet.Range["A1", "G100"].Font.Size = 14;
               
                // kẻ bảng
                worksheet.Range["A6", "F" + (7 + dem)].Borders.LineStyle = 1;
            }
        }
    }
}
