
namespace DOAN_CUOIKY_NHOM4_IM81
{
    partial class FNhaCungCap
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
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.lbTenCongTy = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbQuocGia = new System.Windows.Forms.Label();
            this.lbTP = new System.Windows.Forms.Label();
            this.gVNCC = new System.Windows.Forms.DataGridView();
            this.tbMaNCC = new System.Windows.Forms.TextBox();
            this.tbTenCongTy = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbQuocGia = new System.Windows.Forms.TextBox();
            this.tbTP = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.lbQLHH = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Location = new System.Drawing.Point(59, 89);
            this.lbMaNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(98, 13);
            this.lbMaNCC.TabIndex = 0;
            this.lbMaNCC.Text = "Mã Nhà Cung Cấp:";
            // 
            // lbTenCongTy
            // 
            this.lbTenCongTy.AutoSize = true;
            this.lbTenCongTy.Location = new System.Drawing.Point(85, 120);
            this.lbTenCongTy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenCongTy.Name = "lbTenCongTy";
            this.lbTenCongTy.Size = new System.Drawing.Size(72, 13);
            this.lbTenCongTy.TabIndex = 0;
            this.lbTenCongTy.Text = "Tên Công Ty:";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(113, 151);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(44, 13);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(398, 151);
            this.lbSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(78, 13);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "Số Điện Thoại:";
            // 
            // lbQuocGia
            // 
            this.lbQuocGia.AutoSize = true;
            this.lbQuocGia.Location = new System.Drawing.Point(421, 120);
            this.lbQuocGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuocGia.Name = "lbQuocGia";
            this.lbQuocGia.Size = new System.Drawing.Size(55, 13);
            this.lbQuocGia.TabIndex = 0;
            this.lbQuocGia.Text = "Quốc Gia:";
            // 
            // lbTP
            // 
            this.lbTP.AutoSize = true;
            this.lbTP.Location = new System.Drawing.Point(413, 89);
            this.lbTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTP.Name = "lbTP";
            this.lbTP.Size = new System.Drawing.Size(63, 13);
            this.lbTP.TabIndex = 0;
            this.lbTP.Text = "Thành Phố:";
            // 
            // gVNCC
            // 
            this.gVNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVNCC.Location = new System.Drawing.Point(22, 278);
            this.gVNCC.Margin = new System.Windows.Forms.Padding(2);
            this.gVNCC.Name = "gVNCC";
            this.gVNCC.RowHeadersWidth = 62;
            this.gVNCC.RowTemplate.Height = 28;
            this.gVNCC.Size = new System.Drawing.Size(707, 252);
            this.gVNCC.TabIndex = 1;
            this.gVNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVNCC_CellClick);
            // 
            // tbMaNCC
            // 
            this.tbMaNCC.Enabled = false;
            this.tbMaNCC.Location = new System.Drawing.Point(161, 86);
            this.tbMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaNCC.Name = "tbMaNCC";
            this.tbMaNCC.Size = new System.Drawing.Size(196, 20);
            this.tbMaNCC.TabIndex = 2;
            // 
            // tbTenCongTy
            // 
            this.tbTenCongTy.Location = new System.Drawing.Point(161, 117);
            this.tbTenCongTy.Margin = new System.Windows.Forms.Padding(2);
            this.tbTenCongTy.Name = "tbTenCongTy";
            this.tbTenCongTy.Size = new System.Drawing.Size(196, 20);
            this.tbTenCongTy.TabIndex = 2;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(161, 148);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(196, 20);
            this.tbDiaChi.TabIndex = 2;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(480, 148);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(196, 20);
            this.tbSDT.TabIndex = 2;
            // 
            // tbQuocGia
            // 
            this.tbQuocGia.Location = new System.Drawing.Point(480, 117);
            this.tbQuocGia.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuocGia.Name = "tbQuocGia";
            this.tbQuocGia.Size = new System.Drawing.Size(196, 20);
            this.tbQuocGia.TabIndex = 2;
            // 
            // tbTP
            // 
            this.tbTP.Location = new System.Drawing.Point(480, 86);
            this.tbTP.Margin = new System.Windows.Forms.Padding(2);
            this.tbTP.Name = "tbTP";
            this.tbTP.Size = new System.Drawing.Size(196, 20);
            this.tbTP.TabIndex = 2;
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Location = new System.Drawing.Point(639, 209);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 49);
            this.btXoa.TabIndex = 43;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Location = new System.Drawing.Point(401, 209);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 49);
            this.btThem.TabIndex = 44;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(520, 209);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 49);
            this.btSua.TabIndex = 45;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // lbQLHH
            // 
            this.lbQLHH.BackColor = System.Drawing.Color.Transparent;
            this.lbQLHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLHH.Image = global::DOAN_CUOIKY_NHOM4_IM81.Properties.Resources.icon_duahau;
            this.lbQLHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbQLHH.Location = new System.Drawing.Point(197, 9);
            this.lbQLHH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQLHH.Name = "lbQLHH";
            this.lbQLHH.Size = new System.Drawing.Size(358, 57);
            this.lbQLHH.TabIndex = 46;
            this.lbQLHH.Text = "DANH SÁCH NHÀ CUNG CẤP";
            this.lbQLHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(88, 209);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(90, 49);
            this.btReset.TabIndex = 47;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // FNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 547);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbQLHH);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.tbTP);
            this.Controls.Add(this.tbQuocGia);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTenCongTy);
            this.Controls.Add(this.tbMaNCC);
            this.Controls.Add(this.gVNCC);
            this.Controls.Add(this.lbTP);
            this.Controls.Add(this.lbQuocGia);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenCongTy);
            this.Controls.Add(this.lbMaNCC);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FNhaCungCap";
            this.ShowIcon = false;
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.FNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lbTenCongTy;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbQuocGia;
        private System.Windows.Forms.Label lbTP;
        private System.Windows.Forms.DataGridView gVNCC;
        private System.Windows.Forms.TextBox tbMaNCC;
        private System.Windows.Forms.TextBox tbTenCongTy;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbQuocGia;
        private System.Windows.Forms.TextBox tbTP;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label lbQLHH;
        private System.Windows.Forms.Button btReset;
    }
}
