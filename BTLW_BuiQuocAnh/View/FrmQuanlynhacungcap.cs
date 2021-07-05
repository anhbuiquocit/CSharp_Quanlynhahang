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
    public partial class FrmQuanlynhacungcap : Form
    {
        BALController bal = new BALController();
        public FrmQuanlynhacungcap()
        {
            InitializeComponent();
           
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMancc.Text == "" || txtTenncc.Text == "" || txtDiachincc.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm!");
                bal.insertintoNCC(txtMancc.Text, txtTenncc.Text, txtDiachincc.Text);
                FrmQuanlynhacungcap_Load(sender, e);
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

        private void FrmQuanlynhacungcap_Load(object sender, EventArgs e)
        {
            dgvShowNCC.DataSource = bal.getNCC();
            dgvShowNCC.Columns[1].Width = 350;

            dgvNguyenlieu.DataSource = bal.getNL();
            dgvNguyenlieu.Columns[2].Width = 350;

        }
        private void loadDGVNguyenlieu()
        {
            dgvNguyenlieu.DataSource = bal.getNL();
            dgvNguyenlieu.Columns[2].Width = 350;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMancc.Text == "" || txtTenncc.Text == "" || txtDiachincc.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để Sửa!");
                bal.updateItemInNCC(txtMancc.Text, txtTenncc.Text, txtDiachincc.Text);
                FrmQuanlynhacungcap_Load(sender, e);
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

                if (txtMancc.Text == "")
                    throw new EvaluateException("Bạn cần nhập mã nhà cung cấp để xoá!");
                bal.deleteIteminNCC(txtMancc.Text);
                FrmQuanlynhacungcap_Load(sender, e);
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

        private void btnThem_NL_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtManguyenlieu.Text == "" || txtTennguyenlieu.Text == "" || txtMota.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ thông tin để thêm nguyên liệu");
                bal.insertIteminNL(txtManguyenlieu.Text, txtTennguyenlieu.Text, txtMota.Text);
                loadDGVNguyenlieu();
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

        private void btnSua_NL_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtManguyenlieu.Text == "" || txtTennguyenlieu.Text == "" || txtMota.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ thông tin để sửa nguyên liệu");
                bal.updateIteminNL(txtManguyenlieu.Text, txtTennguyenlieu.Text, txtMota.Text);
                loadDGVNguyenlieu();
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

        private void btnXoa_NL_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtManguyenlieu.Text == "" )
                    throw new EvaluateException("Bạn cần nhập mã nguyên liệu để xoá");
                bal.deleteIteminNL(txtManguyenlieu.Text);
                loadDGVNguyenlieu();
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
