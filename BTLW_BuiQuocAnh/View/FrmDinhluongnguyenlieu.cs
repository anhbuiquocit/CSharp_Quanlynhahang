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
    public partial class FrmDinhluongnguyenlieu : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmDinhluongnguyenlieu()
        {
            InitializeComponent();
        }

        private void FrmDinhluongnguyenlieu_Load(object sender, EventArgs e)
        {
            dgvDinhluongnguyenlieu.DataSource = bal.getListDinhluongnguyenlieu();
            dgvDinhluongnguyenlieu.Columns[1].Width = 200;
            dgvDinhluongnguyenlieu.Columns[2].Width = 200;
            dgvDinhluongnguyenlieu.Columns[3].Width = 200;

            //
            cbbTensp.ValueMember = "masp";
            cbbTensp.DisplayMember = "tensp";
            cbbTensp.DataSource = bal.getNameOfSanpham();


            ///
            cbbTennl.ValueMember = "manguyenlieu";
            cbbTennl.DisplayMember = "tennguyenlieu";
            cbbTennl.DataSource = bal.getNameofNL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMadinhluong.Text == "" || txtDinhluong.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ thông tin để thêm");
                }
                bal.insertIntoDinhluong(txtMadinhluong.Text, cbbTensp.SelectedValue.ToString(), cbbTennl.SelectedValue.ToString(), txtDinhluong.Text);
                FrmDinhluongnguyenlieu_Load(sender, e);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMadinhluong.Text == "" || txtDinhluong.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ thông tin để Sửa");
                }
                bal.updateDinhluong(txtMadinhluong.Text, cbbTensp.SelectedValue.ToString(), cbbTennl.SelectedValue.ToString(), txtDinhluong.Text);
                FrmDinhluongnguyenlieu_Load(sender, e);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMadinhluong.Text == "" || txtDinhluong.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ thông tin để Sửa");
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {

                    bal.deleteDinhluong(txtMadinhluong.Text);
                    FrmDinhluongnguyenlieu_Load(sender, e);
                }
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDinhluongnguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtMadinhluong.Text = dgvDinhluongnguyenlieu.Rows[selectedRow].Cells[0].Value.ToString();
            txtDinhluong.Text = dgvDinhluongnguyenlieu.Rows[selectedRow].Cells[3].Value.ToString();
        }
    }
}
