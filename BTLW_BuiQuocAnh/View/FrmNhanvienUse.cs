using BTLW_BuiQuocAnh.Controller;
using BTLW_BuiQuocAnh.Model;
using BTLW_BuiQuocAnh.View.FrmDangnhap;
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
    public partial class FrmNhanvienUse : Form
    {
        BALController bal = new BALController();
        //get mand to insert into hoadon
        String mand;
        
        //get masp to insert into chitiethoadon
        String masp;
        String mahd;
        int selectedRow;
        int selectedRowDatMon;
        DataTable table;
        List<NguoiDung> listND = new List<NguoiDung>();
        List<HoaDon> listHoaDon = new List<HoaDon>();
        DateTime date = DateTime.Now;
        public FrmNhanvienUse()
        {
            InitializeComponent();
            listND = bal.getListNhanvien();

            //
            cbbTenban.ValueMember = "maban";
            cbbTenban.DisplayMember = "tenban";
            cbbTenban.DataSource = bal.getNameOfBan();
            dgvSanpham.DataSource = bal.getListSanpham();
            btnDatmon.Enabled = false;
            txtSoluong.Enabled = false;
        }
        public FrmNhanvienUse(String mand)
        {
            InitializeComponent();
            this.mand = mand;
            listND = bal.getListNhanvien();

            //
            cbbTenban.ValueMember = "maban";
            cbbTenban.DisplayMember = "tenban";
            cbbTenban.DataSource = bal.getNameOfBan();
            dgvSanpham.DataSource = bal.getListSanpham();

            lvDatmon.Columns.Add("Mã hoá đơn", 70);
            lvDatmon.Columns.Add("Tên món", 70, HorizontalAlignment.Center);
            lvDatmon.Columns.Add("Mã bàn", 100, HorizontalAlignment.Center);
            lvDatmon.Columns.Add("Ngày lập", 70, HorizontalAlignment.Center);
            lvDatmon.Columns.Add("Đơn giá", 70, HorizontalAlignment.Center);
            lvDatmon.Columns.Add("Số lượng", 70, HorizontalAlignment.Center);
            lvDatmon.Columns.Add("Trạng thái", 70, HorizontalAlignment.Center);
            lvDatmon.View = System.Windows.Forms.View.Details;

            btnDatmon.Enabled = false;
            txtSoluong.Enabled = false;


        }

        private void FrmNhanvien_Load(object sender, EventArgs e)
        {
            //lvDatmon.Columns.Add("Mã hoá đơn", 70);
            //lvDatmon.Columns.Add("Tên món", 70, HorizontalAlignment.Center);
            //lvDatmon.Columns.Add("Mã bàn", 100, HorizontalAlignment.Center);
            //lvDatmon.Columns.Add("Ngày lập", 70, HorizontalAlignment.Center);
            //lvDatmon.Columns.Add("Đơn giá", 70, HorizontalAlignment.Center);
            //lvDatmon.Columns.Add("Số lượng", 70, HorizontalAlignment.Center);
            //lvDatmon.Columns.Add("Trạng thái", 70, HorizontalAlignment.Center);
            //lvDatmon.View = System.Windows.Forms.View.Details;
            
            //btnDatmon.Enabled = false;
            //txtSoluong.Enabled = false;



        }

        private void btnDatban_Click(object sender, EventArgs e)
        {


            bal.insertIntoHoadon(mand, cbbTenban.SelectedValue.ToString(), date.ToString(), "0");
            btnDatmon.Enabled = true;
            txtSoluong.Enabled = true;
        }

        private void btnDatmon_Click(object sender, EventArgs e)
        {
            try
            {
                listHoaDon = bal.getListTypeHoaDon();
                //
                int indexOfListHoaDon = listHoaDon.Count - 1;
                mahd = listHoaDon[indexOfListHoaDon].maHD.ToString();


                //MessageBox.Show("Mã hđ" + mahd);
                if (txtMasp.Text == "")
                    throw new EvaluateException("Bạn cần chọn đủ thông tin để đặt món!");
                bal.insertIntoChitiethoadon(mahd, txtMasp.Text, int.Parse(txtSoluong.Text));

                DataTable table = bal.getListDatmon(mahd);
                DisplayinLVDatMon(table);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi sql: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DisplayinLVDatMon(DataTable table)
        {
            lvDatmon.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {

                lvDatmon.Items.Add(table.Rows[i].ItemArray[0].ToString());
                lvDatmon.Items[i].SubItems.Add(table.Rows[i].ItemArray[1].ToString());
                lvDatmon.Items[i].SubItems.Add(table.Rows[i].ItemArray[2].ToString());
                lvDatmon.Items[i].SubItems.Add(table.Rows[i].ItemArray[3].ToString());
                lvDatmon.Items[i].SubItems.Add(table.Rows[i].ItemArray[4].ToString());
                lvDatmon.Items[i].SubItems.Add(table.Rows[i].ItemArray[5].ToString());
                lvDatmon.Items[i].SubItems.Add(table.Rows[i].ItemArray[6].ToString());

            }
        }
        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtMasp.Text = dgvSanpham.Rows[selectedRow].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMahd.Text == "")
                    throw new EvaluateException("Bạn cần nhập mã hoá đơn đẻ tính tiền!");
                bal.ThanhToan(txtMahd.Text);
                DataTable table = bal.getListDatmon(txtMahd.Text);
                DisplayinLVDatMon(table);
                FrmHoadonxuat frm = new FrmHoadonxuat(txtMahd.Text);
                frm.Show();
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi sql: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvDatmon_Click(object sender, EventArgs e)
        {
            txtMabaSearch.Text = lvDatmon.SelectedItems.ToString();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable table = bal.findByMaban(txtMabaSearch.Text);
            DisplayinLVDatMon(table);
        }

        private void FrmNhanvienUse_FormClosed(object sender, FormClosedEventArgs e)
        {
            View.FrmDangnhap.FrmDangnhap.frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn đăng xuất?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(res == DialogResult.Yes)
            {
                
                this.Close();
            }
        }
    }
}
