using BTLW_BuiQuocAnh.View;
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

namespace BTLW_BuiQuocAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void addFormtoPanel(object form)
        {
            if(this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form fn = form as Form;
            fn.TopLevel = false;
            fn.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fn);
            this.panel2.Tag = fn;
            fn.Show();

        }

        private void tsmiQuanlynhanvien_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmQuanlynhanvien());
        }

        private void tsmiQuanlykho_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmQuanlykho());
        }

        private void tsmnQuanlyban_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmQuanlyban());
        }

        private void tsmnQuanlynhacungcap_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmQuanlynhacungcap());
        }

        private void tsmnQuanlythucdon_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmQuanlythucdon());
        }

        private void tsmnQuanlysanpham_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmQuanlysanpham());
        }

        private void tsmnQuanlyloaithucdon_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmQuanlyloaithucdon());
        }

        private void mnDinhluongnguyenlieu_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmDinhluongnguyenlieu());
        }

        private void tsmnQuanlyhoadon_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmHoaDon());
        }

        private void tsmnQuanlythanhtoan_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmChiTietHoaDon());
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            DialogResult reslut = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (reslut == DialogResult.Yes)
            {
                FrmDangnhap.frm.Show();
                this.Close();

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            FrmDangnhap.frm.Show();
        }

        private void mnThongke_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new FrmChart());
        }
    }
}
