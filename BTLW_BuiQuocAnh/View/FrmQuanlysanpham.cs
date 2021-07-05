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
    public partial class FrmQuanlysanpham : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmQuanlysanpham()
        {
            InitializeComponent();
        }

        private void FrmQuanlysanpham_Load(object sender, EventArgs e)
        {
            dgvSanpham.DataSource = bal.getListSanpham();
            dgvSanpham.Columns[1].Width = 250;
            dgvSanpham.Columns[2].Width = 350;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtmasp.Text == "" || txtTensp.Text == "" || txtMota.Text == "" || txtLoai.Text == "" || float.Parse(txtGiaban.Text) < 0)
                {
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm, giá bán không được là số âm");
                }
                bal.insertIntoSanpham(txtmasp.Text, txtTensp.Text, txtMota.Text, float.Parse(txtGiaban.Text), txtLoai.Text);
                FrmQuanlysanpham_Load(sender, e);
            }
            catch(EvaluateException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmasp.Text == "" || txtTensp.Text == "" || txtMota.Text == "" || txtLoai.Text == "" || float.Parse(txtGiaban.Text) < 0)
                {
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để sửa, giá bán không được là số âm");
                }
                bal.updateSanPham(txtmasp.Text, txtTensp.Text, txtMota.Text, float.Parse(txtGiaban.Text), txtLoai.Text);
                FrmQuanlysanpham_Load(sender, e);
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
                if (txtmasp.Text == "" )
                {
                    throw new EvaluateException("Bạn cần nhập mã sản phẩm để xoá");
                }
                bal.deleteSanpham(txtmasp.Text);
                FrmQuanlysanpham_Load(sender, e);
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

        private void dgvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtmasp.Text = dgvSanpham.Rows[selectedRow].Cells[0].Value.ToString();
            txtTensp.Text = dgvSanpham.Rows[selectedRow].Cells[1].Value.ToString();
            txtMota.Text = dgvSanpham.Rows[selectedRow].Cells[2].Value.ToString();
            txtGiaban.Text = dgvSanpham.Rows[selectedRow].Cells[3].Value.ToString();
            txtLoai.Text = dgvSanpham.Rows[selectedRow].Cells[4].Value.ToString();
        }

        private void btnXoachu_Click(object sender, EventArgs e)
        {
            txtmasp.Text = "";
            txtTensp.Text = "";
            txtMota.Text = "";
            txtGiaban.Text = "";
            txtLoai.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFind.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập tên của món ăn ban muốn tìm");
                }
                dgvSanpham.DataSource = bal.findbyNameOfSanpham(txtFind.Text);
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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            FrmQuanlysanpham_Load(sender, e);
        }
    }
}
