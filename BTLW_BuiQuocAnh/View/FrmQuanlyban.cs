using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BTLW_BuiQuocAnh.Controller;

namespace BTLW_BuiQuocAnh.View
{
    public partial class FrmQuanlyban : Form
    {
        BALController bal = new BALController();
        int selectedRow = -1;
        public FrmQuanlyban()
        {
            InitializeComponent();
        }

        private void FrmQuanlyban_Load(object sender, EventArgs e)
        {

            dgvQuanlyban.DataSource = bal.getListBan();
            cbbTinhtrang.Items.Add("0");
            cbbTinhtrang.Items.Add("1");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaban.Text == "" || txtTenban.Text == "" || txtVitri.Text == "" || cbbTinhtrang.SelectedItem.ToString() == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm");
                bal.insertintoBan(txtMaban.Text, txtTenban.Text, txtVitri.Text, cbbTinhtrang.SelectedItem.ToString());
                FrmQuanlyban_Load(sender, e);
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
                if (txtMaban.Text == "" || txtTenban.Text == "" || txtVitri.Text == "" || cbbTinhtrang.SelectedItem.ToString() == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm");
                bal.updateBan(txtMaban.Text, txtTenban.Text, txtVitri.Text, cbbTinhtrang.SelectedItem.ToString());
                FrmQuanlyban_Load(sender, e);
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
                if (txtMaban.Text == "" || txtTenban.Text == "" || txtVitri.Text == "" || cbbTinhtrang.SelectedItem.ToString() == "")
                    throw new EvaluateException("Bạn cần nhập đủ dữ liệu để thêm");
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(res == DialogResult.Yes)
                {

                    bal.deleteBan(txtMaban.Text);
                    FrmQuanlyban_Load(sender, e);
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

        private void btnXoachu_Click(object sender, EventArgs e)
        {
            txtMaban.Text = "";
            txtTenban.Text = "";
            txtVitri.Text = "";
        }

        private void dgvQuanlyban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtMaban.Text = dgvQuanlyban.Rows[selectedRow].Cells[0].Value.ToString();
            txtTenban.Text = dgvQuanlyban.Rows[selectedRow].Cells[1].Value.ToString();
            txtVitri.Text = dgvQuanlyban.Rows[selectedRow].Cells[2].Value.ToString();
            cbbTinhtrang.SelectedItem = dgvQuanlyban.Rows[selectedRow].Cells[3].Value.ToString();
        }
        //private void populate()
        //{
        //    ImageList imgs = new ImageList();
        //    imgs.ImageSize = new Size(50, 50);

        //    String[] path = { };
        //    path = Directory.GetFiles(@"D:\08_Subject\14_Laptrinhwindow\TailieuycBTL\Icon");
        //    try
        //    {
        //        foreach(string p in path)
        //        {

        //            imgs.Images.Add(Image.FromFile(p));
        //        }
        //    }catch(Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    listBan.SmallImageList = imgs;
        //    listBan.Items.Add("Ban1", 2);
        //}
    }
}
