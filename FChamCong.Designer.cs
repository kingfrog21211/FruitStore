
namespace DOAN_CUOIKY_NHOM4_IM81
{
    partial class FChamCong
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
            this.dgChamCong = new System.Windows.Forms.DataGridView();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbVao7h = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbVao17h = new System.Windows.Forms.RadioButton();
            this.rbVao12h = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbRa22h = new System.Windows.Forms.RadioButton();
            this.rbRa17h = new System.Windows.Forms.RadioButton();
            this.rbRa12h = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongGio = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamCong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgChamCong
            // 
            this.dgChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamCong.Location = new System.Drawing.Point(27, 78);
            this.dgChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgChamCong.Name = "dgChamCong";
            this.dgChamCong.RowHeadersWidth = 51;
            this.dgChamCong.RowTemplate.Height = 24;
            this.dgChamCong.Size = new System.Drawing.Size(551, 575);
            this.dgChamCong.TabIndex = 0;
            this.dgChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChamCong_CellClick);
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Location = new System.Drawing.Point(708, 73);
            this.dtpNgayLam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(248, 22);
            this.dtpNgayLam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày làm:";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(733, 121);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(83, 24);
            this.cbMaNV.TabIndex = 3;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân viên:";
            // 
            // rbVao7h
            // 
            this.rbVao7h.AutoSize = true;
            this.rbVao7h.Location = new System.Drawing.Point(24, 58);
            this.rbVao7h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVao7h.Name = "rbVao7h";
            this.rbVao7h.Size = new System.Drawing.Size(66, 24);
            this.rbVao7h.TabIndex = 4;
            this.rbVao7h.TabStop = true;
            this.rbVao7h.Text = "7h00";
            this.rbVao7h.UseVisualStyleBackColor = true;
            this.rbVao7h.CheckedChanged += new System.EventHandler(this.rbVao7h_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbVao17h);
            this.panel1.Controls.Add(this.rbVao12h);
            this.panel1.Controls.Add(this.rbVao7h);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(612, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 174);
            this.panel1.TabIndex = 5;
            // 
            // rbVao17h
            // 
            this.rbVao17h.AutoSize = true;
            this.rbVao17h.Location = new System.Drawing.Point(24, 130);
            this.rbVao17h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVao17h.Name = "rbVao17h";
            this.rbVao17h.Size = new System.Drawing.Size(75, 24);
            this.rbVao17h.TabIndex = 4;
            this.rbVao17h.TabStop = true;
            this.rbVao17h.Text = "17h00";
            this.rbVao17h.UseVisualStyleBackColor = true;
            this.rbVao17h.CheckedChanged += new System.EventHandler(this.rbVao17h_CheckedChanged);
            // 
            // rbVao12h
            // 
            this.rbVao12h.AutoSize = true;
            this.rbVao12h.Location = new System.Drawing.Point(24, 95);
            this.rbVao12h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbVao12h.Name = "rbVao12h";
            this.rbVao12h.Size = new System.Drawing.Size(75, 24);
            this.rbVao12h.TabIndex = 4;
            this.rbVao12h.TabStop = true;
            this.rbVao12h.Text = "12h00";
            this.rbVao12h.UseVisualStyleBackColor = true;
            this.rbVao12h.CheckedChanged += new System.EventHandler(this.rbVao12h_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ vào ca:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbRa22h);
            this.panel2.Controls.Add(this.rbRa17h);
            this.panel2.Controls.Add(this.rbRa12h);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(760, 182);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 174);
            this.panel2.TabIndex = 5;
            // 
            // rbRa22h
            // 
            this.rbRa22h.AutoSize = true;
            this.rbRa22h.Location = new System.Drawing.Point(25, 130);
            this.rbRa22h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRa22h.Name = "rbRa22h";
            this.rbRa22h.Size = new System.Drawing.Size(75, 24);
            this.rbRa22h.TabIndex = 4;
            this.rbRa22h.TabStop = true;
            this.rbRa22h.Text = "22h00";
            this.rbRa22h.UseVisualStyleBackColor = true;
            this.rbRa22h.CheckedChanged += new System.EventHandler(this.rbRa22h_CheckedChanged);
            // 
            // rbRa17h
            // 
            this.rbRa17h.AutoSize = true;
            this.rbRa17h.Location = new System.Drawing.Point(25, 95);
            this.rbRa17h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRa17h.Name = "rbRa17h";
            this.rbRa17h.Size = new System.Drawing.Size(75, 24);
            this.rbRa17h.TabIndex = 4;
            this.rbRa17h.TabStop = true;
            this.rbRa17h.Text = "17h00";
            this.rbRa17h.UseVisualStyleBackColor = true;
            this.rbRa17h.CheckedChanged += new System.EventHandler(this.rbRa17h_CheckedChanged);
            // 
            // rbRa12h
            // 
            this.rbRa12h.AutoSize = true;
            this.rbRa12h.Location = new System.Drawing.Point(25, 58);
            this.rbRa12h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRa12h.Name = "rbRa12h";
            this.rbRa12h.Size = new System.Drawing.Size(75, 24);
            this.rbRa12h.TabIndex = 4;
            this.rbRa12h.TabStop = true;
            this.rbRa12h.Text = "12h00";
            this.rbRa12h.UseVisualStyleBackColor = true;
            this.rbRa12h.CheckedChanged += new System.EventHandler(this.rbRa12h_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giờ ra ca:";
            // 
            // btXacNhan
            // 
            this.btXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btXacNhan.FlatAppearance.BorderSize = 2;
            this.btXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.Location = new System.Drawing.Point(708, 444);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(179, 73);
            this.btXacNhan.TabIndex = 6;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(904, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng giờ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ghi chú:";
            // 
            // txtTongGio
            // 
            this.txtTongGio.Enabled = false;
            this.txtTongGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongGio.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtTongGio.Location = new System.Drawing.Point(906, 263);
            this.txtTongGio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongGio.Name = "txtTongGio";
            this.txtTongGio.Size = new System.Drawing.Size(66, 36);
            this.txtTongGio.TabIndex = 11;
            this.txtTongGio.Text = "0";
            this.txtTongGio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(865, 122);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(110, 22);
            this.txtTenNV.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(822, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Location = new System.Drawing.Point(695, 386);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(267, 22);
            this.txtGhiChu.TabIndex = 12;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(629, 558);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(147, 70);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(815, 558);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(147, 70);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::DOAN_CUOIKY_NHOM4_IM81.Properties.Resources.icon_tao;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(135, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 70);
            this.label5.TabIndex = 14;
            this.label5.Text = "CHẤM CÔNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 673);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtTongGio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayLam);
            this.Controls.Add(this.dgChamCong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FChamCong";
            this.ShowIcon = false;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.FChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChamCong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChamCong;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbVao7h;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbVao17h;
        private System.Windows.Forms.RadioButton rbVao12h;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRa22h;
        private System.Windows.Forms.RadioButton rbRa17h;
        private System.Windows.Forms.RadioButton rbRa12h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongGio;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label5;
    }
}