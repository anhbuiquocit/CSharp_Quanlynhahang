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
    public partial class FrmQuanlynhanvien : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmQuanlynhanvien()
        {
            InitializeComponent();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nu");
        }

        private void FrmQuanlynhanvien_Load(object sender, EventArgs e)
        {
            dgvShowNhanvien.DataSource = bal.getAllNhanvien();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtManv.Text == "" || txtHoten.Text == "" || txtEmail.Text == "" || txtDienThoai.Text == "" || txtDiachi.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtDienThoai.Text == "" || txtDiachi.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm!");
                //String manhanvien, String hoten, String gioitinh, String email, String username, String passWord, int loaitk, String ngaysinh
                bal.insertNhanVien(txtManv.Text, txtHoten.Text, cbbGioiTinh.SelectedItem.ToString(), txtEmail.Text, txtUsername.Text, txtPassword.Text, DtpNgaySinh.Value.ToString(), txtDienThoai.Text, txtDiachi.Text);
                FrmQuanlynhanvien_Load(sender, e);
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
                if (txtManv.Text == "" || txtHoten.Text == "" || txtEmail.Text == "" || txtDienThoai.Text == "" || txtDiachi.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtDienThoai.Text == "" || txtDiachi.Text == ""|| cbbGioiTinh.SelectedItem.ToString()=="")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để sửa!");
                bal.updateNhanVien(txtManv.Text, txtHoten.Text, cbbGioiTinh.SelectedItem.ToString(), txtEmail.Text, txtUsername.Text, txtPassword.Text, DtpNgaySinh.Value.ToString(), txtDienThoai.Text, txtDiachi.Text);
                FrmQuanlynhanvien_Load(sender, e);
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

        private void dgvShowNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtManv.Text = dgvShowNhanvien.Rows[selectedRow].Cells[0].Value.ToString();
            txtHoten.Text = dgvShowNhanvien.Rows[selectedRow].Cells[1].Value.ToString();
            txtDienThoai.Text = dgvShowNhanvien.Rows[selectedRow].Cells[8].Value.ToString();
            txtEmail.Text = dgvShowNhanvien.Rows[selectedRow].Cells[3].Value.ToString();
            txtUsername.Text = dgvShowNhanvien.Rows[selectedRow].Cells[4].Value.ToString();
            txtPassword.Text = dgvShowNhanvien.Rows[selectedRow].Cells[5].Value.ToString();
            txtDiachi.Text = dgvShowNhanvien.Rows[selectedRow].Cells[9].Value.ToString();
            DtpNgaySinh.Value = (DateTime)dgvShowNhanvien.Rows[selectedRow].Cells[7].Value;
            cbbGioiTinh.SelectedItem = dgvShowNhanvien.Rows[selectedRow].Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtManv.Text == "" || txtHoten.Text == "" || txtEmail.Text == "" || txtDienThoai.Text == "" || txtDiachi.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtDienThoai.Text == "" || txtDiachi.Text == "" || cbbGioiTinh.SelectedItem.ToString() == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để sửa!");
                bal.deleteNhanVien(txtManv.Text);
                FrmQuanlynhanvien_Load(sender, e);
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

        private void btnXoachu_Click(object sender, EventArgs e)
        {
            txtManv.Text = "";
            txtHoten.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtDiachi.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbbTieuchi.SelectedItem.ToString() == "" || txtSearch.Text == "")
                    throw new EvaluateException("Bạn cần chọn tiêu chí tìm kiếm và nhập text để tìm");
                if(cbbTieuchi.SelectedItem.ToString() == "Ma nv")
                {
                    dgvShowNhanvien.DataSource = bal.findByManv(txtSearch.Text);
                }
                else if(cbbTieuchi.SelectedItem.ToString() == "Ho ten")
                {
                    dgvShowNhanvien.DataSource = bal.findByHoten(txtSearch.Text);
                }
                else if(cbbTieuchi.SelectedItem.ToString() == "Dia chi")
                {
                    dgvShowNhanvien.DataSource = bal.findByDiaChi(txtSearch.Text);
                }
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
            FrmQuanlynhanvien_Load(sender, e);
        }
    }
}
