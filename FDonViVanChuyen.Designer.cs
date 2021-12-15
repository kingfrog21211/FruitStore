
namespace DOAN_CUOIKY_NHOM4_IM81
{
    partial class FDonViVanChuyen
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
            this.txtMaShipper = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gVDVVC = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbQLHH = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVDVVC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaShipper
            // 
            this.txtMaShipper.Enabled = false;
            this.txtMaShipper.Location = new System.Drawing.Point(195, 85);
            this.txtMaShipper.Name = "txtMaShipper";
            this.txtMaShipper.Size = new System.Drawing.Size(196, 20);
            this.txtMaShipper.TabIndex = 0;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(195, 119);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(196, 20);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(195, 153);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã ĐVVC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đơn vị vận chuyển :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone :";
            // 
            // gVDVVC
            // 
            this.gVDVVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVDVVC.Location = new System.Drawing.Point(22, 272);
            this.gVDVVC.Name = "gVDVVC";
            this.gVDVVC.Size = new System.Drawing.Size(707, 252);
            this.gVDVVC.TabIndex = 6;
            this.gVDVVC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVDVVC_CellClick);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Location = new System.Drawing.Point(460, 85);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(87, 67);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Location = new System.Drawing.Point(519, 181);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(87, 65);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Location = new System.Drawing.Point(578, 85);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(87, 67);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbQLHH
            // 
            this.lbQLHH.BackColor = System.Drawing.Color.Transparent;
            this.lbQLHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLHH.Image = global::DOAN_CUOIKY_NHOM4_IM81.Properties.Resources.icon_nho;
            this.lbQLHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbQLHH.Location = new System.Drawing.Point(168, 9);
            this.lbQLHH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQLHH.Name = "lbQLHH";
            this.lbQLHH.Size = new System.Drawing.Size(416, 57);
            this.lbQLHH.TabIndex = 47;
            this.lbQLHH.Text = "DANH SÁCH ĐƠN VỊ VẬN CHUYỂN";
            this.lbQLHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(68, 197);
            this.btReset.Margin = new System.Windows.Forms.Padding(2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(90, 49);
            this.btReset.TabIndex = 48;
            this.btReset.Text = "Làm mới";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // FDonViVanChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 547);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbQLHH);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.gVDVVC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtMaShipper);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDonViVanChuyen";
            this.ShowIcon = false;
            this.Text = "DonViVanChuyen";
            this.Load += new System.EventHandler(this.FDonViVanChuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVDVVC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaShipper;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gVDVVC;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lbQLHH;
        private System.Windows.Forms.Button btReset;
    }
}