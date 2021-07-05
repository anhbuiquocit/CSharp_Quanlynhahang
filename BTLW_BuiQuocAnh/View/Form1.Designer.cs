
namespace BTLW_BuiQuocAnh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlynhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlykho = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlyban = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlynhacungcap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThucdon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlythucdon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlysanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlyloaithucdon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDinhluongnguyenlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlyhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnQuanlythanhtoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.994709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.00529F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1445, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 40);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQuanly,
            this.mnThucdon,
            this.mnDinhluongnguyenlieu,
            this.tsmnHoadon,
            this.mnThongke,
            this.mnTrogiup,
            this.mnThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1439, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnQuanly
            // 
            this.mnQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnQuanlynhanvien,
            this.tsmnQuanlykho,
            this.tsmnQuanlyban,
            this.tsmnQuanlynhacungcap});
            this.mnQuanly.Name = "mnQuanly";
            this.mnQuanly.Size = new System.Drawing.Size(60, 20);
            this.mnQuanly.Text = "Quản lý";
            // 
            // tsmnQuanlynhanvien
            // 
            this.tsmnQuanlynhanvien.Image = global::BTLW_BuiQuocAnh.Properties.Resources.team;
            this.tsmnQuanlynhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlynhanvien.Name = "tsmnQuanlynhanvien";
            this.tsmnQuanlynhanvien.Size = new System.Drawing.Size(190, 22);
            this.tsmnQuanlynhanvien.Text = "Quản lý nhân viên";
            this.tsmnQuanlynhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlynhanvien.Click += new System.EventHandler(this.tsmiQuanlynhanvien_Click);
            // 
            // tsmnQuanlykho
            // 
            this.tsmnQuanlykho.Image = global::BTLW_BuiQuocAnh.Properties.Resources.warehouse;
            this.tsmnQuanlykho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlykho.Name = "tsmnQuanlykho";
            this.tsmnQuanlykho.Size = new System.Drawing.Size(190, 22);
            this.tsmnQuanlykho.Text = "Quản lý kho";
            this.tsmnQuanlykho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlykho.Click += new System.EventHandler(this.tsmiQuanlykho_Click);
            // 
            // tsmnQuanlyban
            // 
            this.tsmnQuanlyban.Image = global::BTLW_BuiQuocAnh.Properties.Resources.table1;
            this.tsmnQuanlyban.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlyban.Name = "tsmnQuanlyban";
            this.tsmnQuanlyban.Size = new System.Drawing.Size(190, 22);
            this.tsmnQuanlyban.Text = "Quản lý bàn";
            this.tsmnQuanlyban.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlyban.Click += new System.EventHandler(this.tsmnQuanlyban_Click);
            // 
            // tsmnQuanlynhacungcap
            // 
            this.tsmnQuanlynhacungcap.Image = global::BTLW_BuiQuocAnh.Properties.Resources.forklift;
            this.tsmnQuanlynhacungcap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlynhacungcap.Name = "tsmnQuanlynhacungcap";
            this.tsmnQuanlynhacungcap.Size = new System.Drawing.Size(190, 22);
            this.tsmnQuanlynhacungcap.Text = "Quản lý nhà cung cấp";
            this.tsmnQuanlynhacungcap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlynhacungcap.Click += new System.EventHandler(this.tsmnQuanlynhacungcap_Click);
            // 
            // mnThucdon
            // 
            this.mnThucdon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnQuanlythucdon,
            this.tsmnQuanlysanpham,
            this.tsmnQuanlyloaithucdon});
            this.mnThucdon.Name = "mnThucdon";
            this.mnThucdon.Size = new System.Drawing.Size(69, 20);
            this.mnThucdon.Text = "Thực đơn";
            // 
            // tsmnQuanlythucdon
            // 
            this.tsmnQuanlythucdon.Image = global::BTLW_BuiQuocAnh.Properties.Resources.menu;
            this.tsmnQuanlythucdon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlythucdon.Name = "tsmnQuanlythucdon";
            this.tsmnQuanlythucdon.Size = new System.Drawing.Size(188, 22);
            this.tsmnQuanlythucdon.Text = "Quản lý thực đơn";
            this.tsmnQuanlythucdon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlythucdon.Click += new System.EventHandler(this.tsmnQuanlythucdon_Click);
            // 
            // tsmnQuanlysanpham
            // 
            this.tsmnQuanlysanpham.Image = global::BTLW_BuiQuocAnh.Properties.Resources.bake;
            this.tsmnQuanlysanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlysanpham.Name = "tsmnQuanlysanpham";
            this.tsmnQuanlysanpham.Size = new System.Drawing.Size(188, 22);
            this.tsmnQuanlysanpham.Text = "Quản lý sản phẩm";
            this.tsmnQuanlysanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlysanpham.Click += new System.EventHandler(this.tsmnQuanlysanpham_Click);
            // 
            // tsmnQuanlyloaithucdon
            // 
            this.tsmnQuanlyloaithucdon.Image = global::BTLW_BuiQuocAnh.Properties.Resources.menu;
            this.tsmnQuanlyloaithucdon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlyloaithucdon.Name = "tsmnQuanlyloaithucdon";
            this.tsmnQuanlyloaithucdon.Size = new System.Drawing.Size(188, 22);
            this.tsmnQuanlyloaithucdon.Text = "Quản lý loại thực đơn";
            this.tsmnQuanlyloaithucdon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlyloaithucdon.Click += new System.EventHandler(this.tsmnQuanlyloaithucdon_Click);
            // 
            // mnDinhluongnguyenlieu
            // 
            this.mnDinhluongnguyenlieu.Name = "mnDinhluongnguyenlieu";
            this.mnDinhluongnguyenlieu.Size = new System.Drawing.Size(143, 20);
            this.mnDinhluongnguyenlieu.Text = "Định lượng nguyên liệu";
            this.mnDinhluongnguyenlieu.Click += new System.EventHandler(this.mnDinhluongnguyenlieu_Click);
            // 
            // tsmnHoadon
            // 
            this.tsmnHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnQuanlyhoadon,
            this.tsmnQuanlythanhtoan});
            this.tsmnHoadon.Name = "tsmnHoadon";
            this.tsmnHoadon.Size = new System.Drawing.Size(65, 20);
            this.tsmnHoadon.Text = "Hoá đơn";
            // 
            // tsmnQuanlyhoadon
            // 
            this.tsmnQuanlyhoadon.Image = global::BTLW_BuiQuocAnh.Properties.Resources.order;
            this.tsmnQuanlyhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlyhoadon.Name = "tsmnQuanlyhoadon";
            this.tsmnQuanlyhoadon.Size = new System.Drawing.Size(176, 22);
            this.tsmnQuanlyhoadon.Text = "Quản lý hoá đơn";
            this.tsmnQuanlyhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlyhoadon.Click += new System.EventHandler(this.tsmnQuanlyhoadon_Click);
            // 
            // tsmnQuanlythanhtoan
            // 
            this.tsmnQuanlythanhtoan.Image = global::BTLW_BuiQuocAnh.Properties.Resources.money;
            this.tsmnQuanlythanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsmnQuanlythanhtoan.Name = "tsmnQuanlythanhtoan";
            this.tsmnQuanlythanhtoan.Size = new System.Drawing.Size(176, 22);
            this.tsmnQuanlythanhtoan.Text = "Quản lý thanh toán";
            this.tsmnQuanlythanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmnQuanlythanhtoan.Click += new System.EventHandler(this.tsmnQuanlythanhtoan_Click);
            // 
            // mnTrogiup
            // 
            this.mnTrogiup.Name = "mnTrogiup";
            this.mnTrogiup.Size = new System.Drawing.Size(62, 20);
            this.mnTrogiup.Text = "Trợ giúp";
            // 
            // mnThoat
            // 
            this.mnThoat.Image = global::BTLW_BuiQuocAnh.Properties.Resources.power_off;
            this.mnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(65, 20);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BTLW_BuiQuocAnh.Properties.Resources.hinh_nen_mau_xam;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1439, 470);
            this.panel2.TabIndex = 1;
            // 
            // mnThongke
            // 
            this.mnThongke.Name = "mnThongke";
            this.mnThongke.Size = new System.Drawing.Size(68, 20);
            this.mnThongke.Text = "Thống kê";
            this.mnThongke.Click += new System.EventHandler(this.mnThongke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsmQuanlynhanvien;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnQuanly;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnThucdon;
        private System.Windows.Forms.ToolStripMenuItem mnDinhluongnguyenlieu;
        private System.Windows.Forms.ToolStripMenuItem mnTrogiup;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlynhanvien;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlykho;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlyban;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlynhacungcap;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlythucdon;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlysanpham;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlyloaithucdon;
        private System.Windows.Forms.ToolStripMenuItem tsmnHoadon;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlyhoadon;
        private System.Windows.Forms.ToolStripMenuItem tsmnQuanlythanhtoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem mnThongke;
    }
}

