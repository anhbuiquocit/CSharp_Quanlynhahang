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
    public partial class FrmQuanlythucdon : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmQuanlythucdon()
        {
            InitializeComponent();
        }

        private void FrmQuanlythucdon_Load(object sender, EventArgs e)
        {
            dgvQuanlythucdon.DataSource = bal.getThucDon();
            dgvQuanlythucdon.Columns[1].Width = 350;
            dgvQuanlythucdon.Columns[2].Width = 350;

            //pour data to cbbTenThucDOn
            cbbTenthucdon.ValueMember = "mathucdon";
            cbbTenthucdon.DisplayMember = "tenThucDon";
            cbbTenthucdon.DataSource = bal.getNameOfTenthucdon();
            //pour data to cbbTenmon
            cbbTenmon.ValueMember = "masp";
            cbbTenmon.DisplayMember = "tensp";
            cbbTenmon.DataSource = bal.getNameOfSanpham();

            //pour data to cbbTim
            cbbFind.ValueMember = "mathucdon";
            cbbFind.DisplayMember = "tenThucDon";
            cbbFind.DataSource = bal.getNameOfTenthucdon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaquanly.Text == "")
                    throw new EvaluateException("Bạn cần nhập mã quản lý thực đơn để thêm!");
                bal.insertIntoQuanlythucdon(txtMaquanly.Text.ToUpper(), cbbTenmon.SelectedValue.ToString(), cbbTenthucdon.SelectedValue.ToString());
                FrmQuanlythucdon_Load(sender, e);
                
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
                if (txtMaquanly.Text == "")
                    throw new EvaluateException("Bạn cần nhập mã quản lý thực đơn để thêm!");
                bal.updateQuanlythucdon(txtMaquanly.Text.ToUpper(), cbbTenmon.SelectedValue.ToString(), cbbTenthucdon.SelectedValue.ToString());
                FrmQuanlythucdon_Load(sender, e);
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
                if (txtMaquanly.Text == "")
                    throw new EvaluateException("Bạn cần nhập mã quản lý thực đơn để thêm!");
                DialogResult reslut = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "inform", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(reslut == DialogResult.Yes)
                {

                    bal.deleteQuanlythucdon(txtMaquanly.Text.ToUpper());
                    FrmQuanlythucdon_Load(sender, e);
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

        private void dgvQuanlythucdon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtMaquanly.Text = dgvQuanlythucdon.Rows[selectedRow].Cells[0].Value.ToString();
            
        }

        private void btnXoachu_Click(object sender, EventArgs e)
        {
            txtMaquanly.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvQuanlythucdon.DataSource = bal.findByMaThucDon(cbbFind.SelectedValue.ToString());
        }
    }
}
