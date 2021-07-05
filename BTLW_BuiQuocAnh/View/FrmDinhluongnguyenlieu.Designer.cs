
namespace BTLW_BuiQuocAnh.View
{
    partial class FrmDinhluongnguyenlieu
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMadinhluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTensp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTennl = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDinhluong = new System.Windows.Forms.TextBox();
            this.dgvDinhluongnguyenlieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhluongnguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(461, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Định lượng nguyên liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đinh lượng";
            // 
            // txtMadinhluong
            // 
            this.txtMadinhluong.Location = new System.Drawing.Point(141, 135);
            this.txtMadinhluong.Name = "txtMadinhluong";
            this.txtMadinhluong.Size = new System.Drawing.Size(148, 23);
            this.txtMadinhluong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm";
            // 
            // cbbTensp
            // 
            this.cbbTensp.FormattingEnabled = true;
            this.cbbTensp.Location = new System.Drawing.Point(141, 164);
            this.cbbTensp.Name = "cbbTensp";
            this.cbbTensp.Size = new System.Drawing.Size(115, 23);
            this.cbbTensp.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên nguyên liệu";
            // 
            // cbbTennl
            // 
            this.cbbTennl.FormattingEnabled = true;
            this.cbbTennl.Location = new System.Drawing.Point(141, 193);
            this.cbbTennl.Name = "cbbTennl";
            this.cbbTennl.Size = new System.Drawing.Size(115, 23);
            this.cbbTennl.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Định lượng";
            // 
            // txtDinhluong
            // 
            this.txtDinhluong.Location = new System.Drawing.Point(141, 232);
            this.txtDinhluong.Name = "txtDinhluong";
            this.txtDinhluong.Size = new System.Drawing.Size(148, 23);
            this.txtDinhluong.TabIndex = 4;
            // 
            // dgvDinhluongnguyenlieu
            // 
            this.dgvDinhluongnguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinhluongnguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDinhluongnguyenlieu.Location = new System.Drawing.Point(523, 108);
            this.dgvDinhluongnguyenlieu.Name = "dgvDinhluongnguyenlieu";
            this.dgvDinhluongnguyenlieu.RowTemplate.Height = 25;
            this.dgvDinhluongnguyenlieu.Size = new System.Drawing.Size(795, 175);
            this.dgvDinhluongnguyenlieu.TabIndex = 4;
            this.dgvDinhluongnguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDinhluongnguyenlieu_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "madinhluong";
            this.Column1.HeaderText = "Mã ĐL";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tensp";
            this.Column2.HeaderText = "Tên sản phẩm ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tennguyenlieu";
            this.Column3.HeaderText = "Tên nguyên liệu";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dinhluong";
            this.Column4.HeaderText = "Định lượng";
            this.Column4.Name = "Column4";
            this.Column4.Width = 350;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Image = global::BTLW_BuiQuocAnh.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(332, 131);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Image = global::BTLW_BuiQuocAnh.Properties.Resources.updated;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(332, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 34);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Image = global::BTLW_BuiQuocAnh.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(332, 223);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 34);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FrmDinhluongnguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDinhluongnguyenlieu);
            this.Controls.Add(this.cbbTennl);
            this.Controls.Add(this.cbbTensp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDinhluong);
            this.Controls.Add(this.txtMadinhluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDinhluongnguyenlieu";
            this.Text = "FrmDinhluongnguyenlieu";
            this.Load += new System.EventHandler(this.FrmDinhluongnguyenlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinhluongnguyenlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMadinhluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTensp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTennl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDinhluong;
        private System.Windows.Forms.DataGridView dgvDinhluongnguyenlieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}