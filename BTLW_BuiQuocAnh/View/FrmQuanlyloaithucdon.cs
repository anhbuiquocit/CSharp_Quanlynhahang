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
    public partial class FrmQuanlyloaithucdon : Form
    {
        BALController bal = new BALController();
        public FrmQuanlyloaithucdon()
        {
            InitializeComponent();
        }

        private void Quanlyloaithucdon_Load(object sender, EventArgs e)
        {
            dgvThucdon.DataSource = bal.getListLoaiThucdon();
            dgvThucdon.Columns[1].Width = 250;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMathucdon.Text == "" || txtTenthucdon.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu thêm");
                }
                bal.insertIntoQuanlyloaithucdon(txtMathucdon.Text, txtTenthucdon.Text);
                Quanlyloaithucdon_Load(sender, e);
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
                if (txtMathucdon.Text == "" || txtTenthucdon.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu thêm");
                }
                bal.updateQuanlyloaithucdon(txtMathucdon.Text, txtTenthucdon.Text);
                Quanlyloaithucdon_Load(sender, e);
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
                if (txtMathucdon.Text == "" || txtTenthucdon.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu thêm");
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    bal.deleteQuanlyloaithucdon(txtMathucdon.Text);
                    Quanlyloaithucdon_Load(sender, e);
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
    }
}
