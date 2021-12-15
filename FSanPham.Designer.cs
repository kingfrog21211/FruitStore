
namespace DOAN_CUOIKY_NHOM4_IM81
{
    partial class FSanPham
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
            this.dGVSP = new System.Windows.Forms.DataGridView();
            this.txtTonKho = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbQLHH = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVSP
            // 
            this.dGVSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSP.Location = new System.Drawing.Point(22, 278);
            this.dGVSP.Margin = new System.Windows.Forms.Padding(2);
            this.dGVSP.Name = "dGVSP";
            this.dGVSP.RowHeadersWidth = 51;
            this.dGVSP.RowTemplate.Height = 24;
            this.dGVSP.Size = new System.Drawing.Size(707, 252);
            this.dGVSP.TabIndex = 35;
            this.dGVSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSP_CellClick);
            // 
            // txtTonKho
            // 
            this.txtTonKho.Location = new System.Drawing.Point(448, 120);
            this.txtTonKho.Margin = new System.Windows.Forms.Padding(2);
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Size = new System.Drawing.Size(196, 20);
            this.txtTonKho.TabIndex = 28;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(448, 79);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(196, 20);
            this.txtGia.TabIndex = 26;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(152, 79);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(196, 20);
            this.txtMaSP.TabIndex = 20;
            // 
            // lbQLHH
            // 
            this.lbQLHH.BackColor = System.Drawing.Color.Transparent;
            this.lbQLHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLHH.Image = global::DOAN_CUOIKY_NHOM4_IM81.Properties.Resources.icon_bo;
            this.lbQLHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbQLHH.Location = new System.Drawing.Point(238, 2);
            this.lbQLHH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQLHH.Name = "lbQLHH";
            this.lbQLHH.Size = new System.Drawing.Size(276, 57);
            this.lbQLHH.TabIndex = 18;
            this.lbQLHH.Text = "QUẢN LÝ SẢN PHẨM";
            this.lbQLHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(152, 120);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(196, 20);
            this.txtTenSP.TabIndex = 30;
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(520, 205);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(90, 49);
            this.btSua.TabIndex = 36;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Location = new System.Drawing.Point(639, 205);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(90, 49);
            this.btXoa.TabIndex = 36;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Location = new System.Drawing.Point(401, 205);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(90, 49);
            this.btThem.TabIndex = 36;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã NCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tồn kho:";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(152, 160);
            this.cbMaNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(196, 21);
            this.cbMaNCC.TabIndex = 38;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(77, 205);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(90, 49);
            this.btReset.TabIndex = 39;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // FSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 547);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.cbMaNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.dGVSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtTonKho);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lbQLHH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSanPham";
            this.ShowIcon = false;
            this.Text = "Quan Ly San Pham";
            this.Load += new System.EventHandler(this.FSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.DataGridView dGVSP;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lbQLHH;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.Button btReset;
    }
}