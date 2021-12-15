
namespace DOAN_CUOIKY_NHOM4_IM81
{
    partial class FKhachHang
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

        private void InitializeComponent()
        {
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTP = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.gVDSKH = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTPho = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.lbQLHH = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(74, 88);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(85, 13);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã khách hàng:";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(70, 124);
            this.lbTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(89, 13);
            this.lbTenKH.TabIndex = 2;
            this.lbTenKH.Text = "Tên khách hàng:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(391, 160);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(73, 13);
            this.lbSDT.TabIndex = 3;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // lbTP
            // 
            this.lbTP.AutoSize = true;
            this.lbTP.Location = new System.Drawing.Point(402, 124);
            this.lbTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTP.Name = "lbTP";
            this.lbTP.Size = new System.Drawing.Size(62, 13);
            this.lbTP.TabIndex = 4;
            this.lbTP.Text = "Thành phố:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(421, 88);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(160, 121);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(196, 20);
            this.txtTenKH.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(465, 157);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(196, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // gVDSKH
            // 
            this.gVDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVDSKH.Location = new System.Drawing.Point(22, 278);
            this.gVDSKH.Margin = new System.Windows.Forms.Padding(2);
            this.gVDSKH.Name = "gVDSKH";
            this.gVDSKH.RowHeadersWidth = 62;
            this.gVDSKH.RowTemplate.Height = 28;
            this.gVDSKH.Size = new System.Drawing.Size(707, 252);
            this.gVDSKH.TabIndex = 8;
            this.gVDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVDSKH_CellClick);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(160, 85);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(196, 20);
            this.txtMaKH.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(465, 85);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(196, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTPho
            // 
            this.txtTPho.Location = new System.Drawing.Point(465, 121);
            this.txtTPho.Margin = new System.Windows.Forms.Padding(2);
            this.txtTPho.Name = "txtTPho";
            this.txtTPho.Size = new System.Drawing.Size(196, 20);
            this.txtTPho.TabIndex = 7;
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Location = new System.Drawing.Point(639, 207);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 49);
            this.btXoa.TabIndex = 37;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Location = new System.Drawing.Point(401, 207);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 49);
            this.btThem.TabIndex = 38;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(520, 207);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 49);
            this.btSua.TabIndex = 39;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // lbQLHH
            // 
            this.lbQLHH.BackColor = System.Drawing.Color.Transparent;
            this.lbQLHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLHH.Image = global::DOAN_CUOIKY_NHOM4_IM81.Properties.Resources.icon_chanh;
            this.lbQLHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbQLHH.Location = new System.Drawing.Point(224, 9);
            this.lbQLHH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQLHH.Name = "lbQLHH";
            this.lbQLHH.Size = new System.Drawing.Size(305, 57);
            this.lbQLHH.TabIndex = 40;
            this.lbQLHH.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.lbQLHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(69, 207);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(90, 49);
            this.btReset.TabIndex = 41;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // FKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 547);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbQLHH);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.gVDSKH);
            this.Controls.Add(this.txtTPho);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTP);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.lbMaKH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FKhachHang";
            this.ShowIcon = false;
            this.Text = "Quan Ly Khach Hang";
            this.Load += new System.EventHandler(this.FKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVDSKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTP;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView gVDSKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTPho;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label lbQLHH;
        private System.Windows.Forms.Button btReset;
    }
}
