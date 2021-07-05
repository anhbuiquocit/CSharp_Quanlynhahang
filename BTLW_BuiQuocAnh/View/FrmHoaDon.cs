using BTLW_BuiQuocAnh.Controller;
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
    public partial class FrmHoaDon : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            dgvQuanlyhoadon.DataSource = bal.getListHoadon();
            cbbTennhanvien.ValueMember = "manguoidung";
            cbbTennhanvien.DisplayMember = "hoten";
            cbbTennhanvien.DataSource = bal.getNameOfNv();
            ////
            cbbTenban.ValueMember = "maban";
            cbbTenban.DisplayMember = "tenban";
            cbbTenban.DataSource = bal.getNameOfBan();

            cbbTinhtrang.Items.Add("0");
            cbbTinhtrang.Items.Add("1");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbTennhanvien.SelectedItem.ToString() == "" || cbbTenban.SelectedItem.ToString() == "" || cbbTinhtrang.SelectedItem.ToString() == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm!");
                }
                bal.insertIntoHoadon(cbbTennhanvien.SelectedValue.ToString(), cbbTenban.SelectedValue.ToString(), dtpNgaylaphd.Value.ToString(), cbbTinhtrang.SelectedItem.ToString());
                FrmHoaDon_Load(sender, e);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMahd.Text == "" || cbbTennhanvien.SelectedItem.ToString() == "" || cbbTenban.SelectedItem.ToString() == "" || cbbTinhtrang.SelectedItem.ToString() == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để Sửa!");
                }
                bal.updateHoadon(txtMahd.Text, cbbTennhanvien.SelectedValue.ToString(), cbbTenban.SelectedValue.ToString(), dtpNgaylaphd.Value.ToString(), cbbTinhtrang.SelectedItem.ToString());
                FrmHoaDon_Load(sender, e);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMahd.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập mã hoá đơn để xoá!");
                }
                bal.deleteHoaDon(txtMahd.Text);
                FrmHoaDon_Load(sender, e);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuanlyhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtMahd.Text = dgvQuanlyhoadon.Rows[selectedRow].Cells[0].Value.ToString();
            cbbTennhanvien.SelectedItem = dgvQuanlyhoadon.Rows[selectedRow].Cells[1].Value.ToString();
            cbbTenban.SelectedItem = dgvQuanlyhoadon.Rows[selectedRow].Cells[2].Value.ToString();
            dtpNgaylaphd.Value = (DateTime) dgvQuanlyhoadon.Rows[selectedRow].Cells[3].Value;
        }

        private void btnXoachu_Click(object sender, EventArgs e)
        {
            txtMahd.Text = "";
        }
    }
}
