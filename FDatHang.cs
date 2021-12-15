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
    public partial class FDatHang : Form
    {
        public int maDH;
        BUS_DonHang busDH;
        DataTable dtSanPham;
        bool co = false;
        public FDatHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }
        private void ComboBoxSP()
        {
            busDH.HienThiCBSanPham(cbTenSanPham);
        }
        void HienThiGiaSP(int maSP)
        {
            if (maSP > 0)
            {
                Product p = busDH.LayThongTinSP(maSP);
                cbTenSanPham.Text = p.ProductName;
                txtDonGia.Text = p.UnitPrice.ToString();
            }
        }
        private void FDatHang_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDH.ToString();
            ComboBoxSP();
            co = true;
            //DataTable
            dtSanPham = new DataTable();
            dtSanPham.Columns.Add("ProductID");
            dtSanPham.Columns.Add("UnitPrice");
            dtSanPham.Columns.Add("Quantity");
            dtSanPham.Columns.Add("Discount");
            dgvChiTietDonHang.DataSource = dtSanPham;
            //kích thước
            dgvChiTietDonHang.Columns[0].Width = (int)(dgvChiTietDonHang.Width * 0.2);
            dgvChiTietDonHang.Columns[1].Width = (int)(dgvChiTietDonHang.Width * 0.22);
            dgvChiTietDonHang.Columns[2].Width = (int)(dgvChiTietDonHang.Width * 0.25);
            dgvChiTietDonHang.Columns[3].Width = (int)(dgvChiTietDonHang.Width * 0.25);
        }

        private void cbTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co == true)
                HienThiGiaSP(int.Parse(cbTenSanPham.SelectedValue.ToString()));
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            bool trangThai = true;
            foreach (DataRow item in dtSanPham.Rows)
            {
                if (item[0].ToString() == cbTenSanPham.SelectedValue.ToString())
                {
                    trangThai = false;
                    item[2] = int.Parse(item[2].ToString()) + int.Parse(txtSoLuong.Text);//cập nhật số lượng
                    break;
                }
            }
            if (trangThai)
            {
                DataRow r = dtSanPham.NewRow();
                r[0] = cbTenSanPham.SelectedValue.ToString();
                r[1] = txtDonGia.Text;
                r[2] = txtSoLuong.Text;
                r[3] = txtGiamGia.Text;
                dtSanPham.Rows.Add(r);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DataRow r = dtSanPham.Rows[dgvChiTietDonHang.CurrentRow.Index];
            r[0] = cbTenSanPham.SelectedValue.ToString();
            r[1] = txtDonGia.Text;
            r[2] = txtSoLuong.Text;
            r[3] = txtGiamGia.Text;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dtSanPham.Rows.Count > 0)
                dtSanPham.Rows.RemoveAt(dgvChiTietDonHang.CurrentRow.Index);
            else
                MessageBox.Show("Lỗi: Chưa có sản phẩm nào được thêm");
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (busDH.DatHang(dtSanPham, maDH))
                {
                    MessageBox.Show("Đặt hàng thành công!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void dgvChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvChiTietDonHang.Rows.Count-1)
            {
                cbTenSanPham.SelectedValue = int.Parse(dgvChiTietDonHang.Rows[e.RowIndex].Cells["ProductID"].Value.ToString());
                txtSoLuong.Text = dgvChiTietDonHang.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                txtGiamGia.Text = dgvChiTietDonHang.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
            }
        }
    }
}
