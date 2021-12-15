using DOAN_CUOIKY_NHOM4_IM81.BUS;
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
    public partial class FSanPham : Form
    {
        public int maSP;
        BUS_DonHang busSP;
        public FSanPham()
        {
            InitializeComponent();
            busSP = new BUS_DonHang();
        }
        private void HienThiDSSanPham()
        {
            dGVSP.DataSource = null;
            busSP.HienThiDSSanPham(dGVSP);
            dGVSP.Columns[0].Width = (int)(dGVSP.Width * 0.2);
            dGVSP.Columns[1].Width = (int)(dGVSP.Width * 0.15);
            dGVSP.Columns[2].Width = (int)(dGVSP.Width * 0.15);
            dGVSP.Columns[3].Width = (int)(dGVSP.Width * 0.2);
            dGVSP.Columns[4].Width = (int)(dGVSP.Width * 0.2);
        }
        private void ComboBoxMaNCC()
        {
            busSP.HienThiCBMaNCC(cbMaNCC);
        }
        private void FSanPham_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            txtMaSP.Enabled = false;
            ComboBoxMaNCC();
        }

        private void dGVSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVSP.Rows.Count)
            {
                txtMaSP.Text = dGVSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtTenSP.Text = dGVSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbMaNCC.Text = dGVSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGia.Text = dGVSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTonKho.Text = dGVSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ProductName = txtTenSP.Text;
                p.SupplierID = int.Parse(cbMaNCC.Text);
                p.UnitPrice = decimal.Parse(txtGia.Text);
                p.UnitInStock = short.Parse(txtTonKho.Text);
                if (busSP.SP_Them(p))
                {
                    MessageBox.Show("Tạo sản phẩm thành công!");
                    busSP.HienThiDSSanPham(dGVSP);
                }
                else
                {
                    MessageBox.Show("Tạo sản phẩm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ProductID = int.Parse(txtMaSP.Text);
                p.ProductName = txtTenSP.Text;
                p.SupplierID = int.Parse(cbMaNCC.Text);
                p.UnitPrice = decimal.Parse(txtGia.Text);
                p.UnitInStock = short.Parse(txtTonKho.Text);
                if (busSP.SP_Sua(p))
                {
                    MessageBox.Show("Sửa sản phẩm thành công!");
                    busSP.HienThiDSSanPham(dGVSP);
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ProductID = int.Parse(txtMaSP.Text);
                if (busSP.SP_Xoa(p))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    busSP.HienThiDSSanPham(dGVSP);
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtTonKho.Clear();
        }
    }
}
