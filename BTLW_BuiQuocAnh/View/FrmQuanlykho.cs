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
    public partial class FrmQuanlykho : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmQuanlykho()
        {
            InitializeComponent();
            // insert value into cbbTennguyenlieu
            CbbTennguyenlieu.ValueMember = "manguyenlieu";
            CbbTennguyenlieu.DisplayMember = "tennguyenlieu";
            CbbTennguyenlieu.DataSource = bal.getNameofNL();

            //insert value into CbbTenncc
            CbbTencc.ValueMember = "mancc";
            CbbTencc.DisplayMember = "tenncc";
            CbbTencc.DataSource = bal.getNameOfNCC();

        }

        private void FrmQuanlykho_Load(object sender, EventArgs e)
        {
            dgvQuanlykho.DataSource = bal.getAllInQuanlykho();
            dgvQuanlykho.Columns[1].Width = 250;
            dgvQuanlykho.Columns[2].Width = 350;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaqly.Text == "" || txtDongia.Text == "" || txtSoluong.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm");
                bal.insertintoQuanlykho(txtMaqly.Text.ToUpper(), CbbTennguyenlieu.SelectedValue.ToString(), CbbTencc.SelectedValue.ToString(), int.Parse(txtDongia.Text), int.Parse(txtSoluong.Text));
                FrmQuanlykho_Load(sender, e);
            }
            catch(EvaluateException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaqly.Text == "" || txtDongia.Text == "" || txtSoluong.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để sửa");
                
                bal.updateQuanlykho(txtMaqly.Text, CbbTennguyenlieu.SelectedValue.ToString(), CbbTencc.SelectedValue.ToString(), int.Parse(txtDongia.Text), int.Parse(txtSoluong.Text));
                FrmQuanlykho_Load(sender, e);
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
                if (txtMaqly.Text == "" || txtDongia.Text == "" || txtSoluong.Text == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm");
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    bal.deleteQuanlykho(txtMaqly.Text.ToUpper());
                    FrmQuanlykho_Load(sender, e);
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

        private void dgvQuanlykho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtMaqly.Text = dgvQuanlykho.Rows[selectedRow].Cells[0].Value.ToString();
            //CbbTennguyenlieu.SelectedItem = dgvQuanlykho.Rows[selectedRow].Cells[1].Value.ToString();
            //CbbTencc.SelectedItem  = dgvQuanlykho.Rows[selectedRow].Cells[2].Value.ToString();
            txtDongia.Text = dgvQuanlykho.Rows[selectedRow].Cells[3].Value.ToString();
            txtSoluong.Text = dgvQuanlykho.Rows[selectedRow].Cells[4].Value.ToString();
        }

        private void btnXoachu_Click(object sender, EventArgs e)
        {
            txtMaqly.Text = "";
            txtDongia.Text = "";
            txtSoluong.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbTieuchi.SelectedItem.ToString() == "" || txtSearchContent.Text == "")
                {
                    throw new EvaluateException("Bạn cần nhập tiêu chí tìm kiếm và nọi dung tìm kiếm!");
                }
                if (cbbTieuchi.SelectedItem.ToString() == "Ten nguyen lieu")
                {
                    dgvQuanlykho.DataSource = bal.findBytenNguyenlieu(txtSearchContent.Text);

                }
                else if (cbbTieuchi.SelectedItem.ToString() == "Ten nha cung cap")
                {
                    dgvQuanlykho.DataSource = bal.findBytenNhacungcap(txtSearchContent.Text);
                }
            } catch (EvaluateException ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            FrmQuanlykho_Load(sender, e);
        }
    }
}
