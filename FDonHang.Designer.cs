namespace DOAN_CUOIKY_NHOM4_IM81
{
    partial class FDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.txtDiaChiGiaoHang = new System.Windows.Forms.TextBox();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayDatHang = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.cbShipperID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonHang.Location = new System.Drawing.Point(29, 342);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDonHang.Name = "dgvDonHang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(943, 310);
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            this.dgvDonHang.DoubleClick += new System.EventHandler(this.dgvDonHang_DoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DOAN_CUOIKY_NHOM4_IM81.Properties.Resources.icon_cherry;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(283, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày đặt hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày giao hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ giao hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Thành phố:";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Enabled = false;
            this.txtMaDonHang.Location = new System.Drawing.Point(211, 89);
            this.txtMaDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(260, 22);
            this.txtMaDonHang.TabIndex = 3;
            // 
            // txtDiaChiGiaoHang
            // 
            this.txtDiaChiGiaoHang.Location = new System.Drawing.Point(651, 176);
            this.txtDiaChiGiaoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiGiaoHang.Name = "txtDiaChiGiaoHang";
            this.txtDiaChiGiaoHang.Size = new System.Drawing.Size(260, 22);
            this.txtDiaChiGiaoHang.TabIndex = 3;
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Location = new System.Drawing.Point(651, 218);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(260, 22);
            this.txtThanhPho.TabIndex = 3;
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(211, 132);
            this.cbMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(260, 24);
            this.cbMaKhachHang.TabIndex = 4;
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(211, 176);
            this.cbMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(260, 24);
            this.cbMaNhanVien.TabIndex = 4;
            // 
            // dtpNgayDatHang
            // 
            this.dtpNgayDatHang.Location = new System.Drawing.Point(651, 89);
            this.dtpNgayDatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayDatHang.Name = "dtpNgayDatHang";
            this.dtpNgayDatHang.Size = new System.Drawing.Size(260, 22);
            this.dtpNgayDatHang.TabIndex = 5;
            // 
            // dtpNgayGiaoHang
            // 
            this.dtpNgayGiaoHang.Location = new System.Drawing.Point(651, 132);
            this.dtpNgayGiaoHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayGiaoHang.Name = "dtpNgayGiaoHang";
            this.dtpNgayGiaoHang.Size = new System.Drawing.Size(260, 22);
            this.dtpNgayGiaoHang.TabIndex = 5;
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Location = new System.Drawing.Point(535, 265);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(120, 60);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(695, 265);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(120, 60);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Location = new System.Drawing.Point(852, 265);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(120, 60);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(100, 265);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(120, 60);
            this.btReset.TabIndex = 40;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // cbShipperID
            // 
            this.cbShipperID.FormattingEnabled = true;
            this.cbShipperID.Location = new System.Drawing.Point(211, 218);
            this.cbShipperID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShipperID.Name = "cbShipperID";
            this.cbShipperID.Size = new System.Drawing.Size(260, 24);
            this.cbShipperID.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Mã ĐV Vận Chuyển:";
            // 
            // FDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1003, 673);
            this.Controls.Add(this.cbShipperID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dtpNgayGiaoHang);
            this.Controls.Add(this.dtpNgayDatHang);
            this.Controls.Add(this.cbMaNhanVien);
            this.Controls.Add(this.cbMaKhachHang);
            this.Controls.Add(this.txtThanhPho);
            this.Controls.Add(this.txtDiaChiGiaoHang);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDonHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDonHang";
            this.ShowIcon = false;
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.FDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtDiaChiGiaoHang;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayDatHang;
        private System.Windows.Forms.DateTimePicker dtpNgayGiaoHang;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.ComboBox cbShipperID;
        private System.Windows.Forms.Label label9;
    }
}