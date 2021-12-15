using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_CUOIKY_NHOM4_IM81
{
    public partial class FManHinhChinh : Form
    {
        public FManHinhChinh()
        {
            InitializeComponent();
        }

        private void linkLbDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FDangNhap f = new FDangNhap();
            f.Show();
        }
        public void DisposeAllInActiveForms()//đóng các form con khác đang active
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }
        private void btDanhSachDonHang_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FDonHang f = new FDonHang();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }

        private void btChiTietDonHang_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FChiTietDonHang f = new FChiTietDonHang();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }

        private void btDanhMucSanPham_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FSanPham f = new FSanPham();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }

        private void btDanhMucKhachHang_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FKhachHang f = new FKhachHang();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }

        private void btDanhMucNhanVien_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FNhanVien f = new FNhanVien();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }

        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FNhaCungCap f = new FNhaCungCap();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }

        private void btDonViVanChuyen_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FDonViVanChuyen f = new FDonViVanChuyen();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }

        private void btChamCong_Click(object sender, EventArgs e)
        {
            DisposeAllInActiveForms();
            FChamCong f = new FChamCong();
            f.MdiParent = this;
            f.Dock = System.Windows.Forms.DockStyle.Right;
            f.Show();
        }
    }
}
