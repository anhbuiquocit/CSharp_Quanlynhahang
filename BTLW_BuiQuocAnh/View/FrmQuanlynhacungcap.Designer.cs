
namespace BTLW_BuiQuocAnh.View
{
    partial class FrmQuanlynhacungcap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachincc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvShowNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManguyenlieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTennguyenlieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.btnThemNL = new System.Windows.Forms.Button();
            this.btnSuaNL = new System.Windows.Forms.Button();
            this.btnXoaNL = new System.Windows.Forms.Button();
            this.dgvNguyenlieu = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhà cung cấp";
            // 
            // txtMancc
            // 
            this.txtMancc.Location = new System.Drawing.Point(108, 63);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(134, 23);
            this.txtMancc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã ncc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên ncc";
            // 
            // txtTenncc
            // 
            this.txtTenncc.Location = new System.Drawing.Point(108, 92);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(134, 23);
            this.txtTenncc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // txtDiachincc
            // 
            this.txtDiachincc.Location = new System.Drawing.Point(108, 126);
            this.txtDiachincc.Name = "txtDiachincc";
            this.txtDiachincc.Size = new System.Drawing.Size(134, 23);
            this.txtDiachincc.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Image = global::BTLW_BuiQuocAnh.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(274, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Image = global::BTLW_BuiQuocAnh.Properties.Resources.updated;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(274, 89);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 35);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTLW_BuiQuocAnh.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(274, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 33);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvShowNCC
            // 
            this.dgvShowNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvShowNCC.Location = new System.Drawing.Point(535, 57);
            this.dgvShowNCC.Name = "dgvShowNCC";
            this.dgvShowNCC.RowTemplate.Height = 25;
            this.dgvShowNCC.Size = new System.Drawing.Size(547, 120);
            this.dgvShowNCC.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "mancc";
            this.Column1.HeaderText = "Mã ncc";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenncc";
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diachi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nguyên liệu";
            // 
            // txtManguyenlieu
            // 
            this.txtManguyenlieu.Location = new System.Drawing.Point(108, 245);
            this.txtManguyenlieu.Name = "txtManguyenlieu";
            this.txtManguyenlieu.Size = new System.Drawing.Size(134, 23);
            this.txtManguyenlieu.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên nguyên liệu";
            // 
            // txtTennguyenlieu
            // 
            this.txtTennguyenlieu.Location = new System.Drawing.Point(108, 274);
            this.txtTennguyenlieu.Name = "txtTennguyenlieu";
            this.txtTennguyenlieu.Size = new System.Drawing.Size(134, 23);
            this.txtTennguyenlieu.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô tả";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(108, 308);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(134, 23);
            this.txtMota.TabIndex = 6;
            // 
            // btnThemNL
            // 
            this.btnThemNL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemNL.Image = global::BTLW_BuiQuocAnh.Properties.Resources.add;
            this.btnThemNL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNL.Location = new System.Drawing.Point(274, 237);
            this.btnThemNL.Name = "btnThemNL";
            this.btnThemNL.Size = new System.Drawing.Size(94, 36);
            this.btnThemNL.TabIndex = 10;
            this.btnThemNL.Text = "Thêm";
            this.btnThemNL.UseVisualStyleBackColor = true;
            this.btnThemNL.Click += new System.EventHandler(this.btnThem_NL_Click);
            // 
            // btnSuaNL
            // 
            this.btnSuaNL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaNL.Image = global::BTLW_BuiQuocAnh.Properties.Resources.updated;
            this.btnSuaNL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNL.Location = new System.Drawing.Point(274, 279);
            this.btnSuaNL.Name = "btnSuaNL";
            this.btnSuaNL.Size = new System.Drawing.Size(94, 34);
            this.btnSuaNL.TabIndex = 11;
            this.btnSuaNL.Text = "Sửa";
            this.btnSuaNL.UseVisualStyleBackColor = true;
            this.btnSuaNL.Click += new System.EventHandler(this.btnSua_NL_Click);
            // 
            // btnXoaNL
            // 
            this.btnXoaNL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaNL.Image = global::BTLW_BuiQuocAnh.Properties.Resources.trash;
            this.btnXoaNL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNL.Location = new System.Drawing.Point(274, 316);
            this.btnXoaNL.Name = "btnXoaNL";
            this.btnXoaNL.Size = new System.Drawing.Size(94, 38);
            this.btnXoaNL.TabIndex = 12;
            this.btnXoaNL.Text = "Xoá";
            this.btnXoaNL.UseVisualStyleBackColor = true;
            this.btnXoaNL.Click += new System.EventHandler(this.btnXoa_NL_Click);
            // 
            // dgvNguyenlieu
            // 
            this.dgvNguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNguyenlieu.Location = new System.Drawing.Point(535, 235);
            this.dgvNguyenlieu.Name = "dgvNguyenlieu";
            this.dgvNguyenlieu.RowTemplate.Height = 25;
            this.dgvNguyenlieu.Size = new System.Drawing.Size(547, 142);
            this.dgvNguyenlieu.TabIndex = 3;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "manguyenlieu";
            this.Column4.HeaderText = "Mã nguyên liệu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tennguyenlieu";
            this.Column5.HeaderText = "Tên nguyên liệu";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mota";
            this.Column6.HeaderText = "Mô tả";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(384, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quản lý nguyên liệu";
            // 
            // FrmQuanlynhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1447, 434);
            this.Controls.Add(this.dgvNguyenlieu);
            this.Controls.Add(this.btnXoaNL);
            this.Controls.Add(this.dgvShowNCC);
            this.Controls.Add(this.btnSuaNL);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemNL);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiachincc);
            this.Controls.Add(this.txtTennguyenlieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenncc);
            this.Controls.Add(this.txtManguyenlieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMancc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanlynhacungcap";
            this.Text = "FrmQuanlynhacungcap";
            this.Load += new System.EventHandler(this.FrmQuanlynhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMancc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiachincc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvShowNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtManguyenlieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTennguyenlieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Button btnThemNL;
        private System.Windows.Forms.Button btnSuaNL;
        private System.Windows.Forms.Button btnXoaNL;
        private System.Windows.Forms.DataGridView dgvNguyenlieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}