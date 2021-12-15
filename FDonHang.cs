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
    public partial class FDonHang : Form
    {
        BUS_DonHang busDH;
        public FDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }
        private void HienThiDG()
        {
            dgvDonHang.DataSource = null;
            busDH.HienThiDGDonHang(dgvDonHang);
            dgvDonHang.Columns[0].Width = (int)(dgvDonHang.Width * 0.1);
            dgvDonHang.Columns[1].Width = (int)(dgvDonHang.Width * 0.1);
            dgvDonHang.Columns[2].Width = (int)(dgvDonHang.Width * 0.1);
            dgvDonHang.Columns[3].Width = (int)(dgvDonHang.Width * 0.1);
            dgvDonHang.Columns[4].Width = (int)(dgvDonHang.Width * 0.1);
            dgvDonHang.Columns[5].Width = (int)(dgvDonHang.Width * 0.1);
            dgvDonHang.Columns[6].Width = (int)(dgvDonHang.Width * 0.2);
            dgvDonHang.Columns[7].Width = (int)(dgvDonHang.Width * 0.1);
        }
        private void ComboBoxMaKH()
        {
            busDH.HienThiCBKhachHang(cbMaKhachHang);
        }
        private void ComboBoxMaNV()
        {
            busDH.HienThiCBNhanVien(cbMaNhanVien);
        }
        private void ComboBoxMaShipper()
        {
            busDH.HienThiCBShipper(cbShipperID);
        }
        private void FDonHang_Load(object sender, EventArgs e)
        {
            HienThiDG();
            ComboBoxMaKH();
            ComboBoxMaNV();
            ComboBoxMaShipper();
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDonHang.Rows.Count)
            {
                txtMaDonHang.Text = dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbMaKhachHang.Text = dgvDonHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbMaNhanVien.Text = dgvDonHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayDatHang.Text = dgvDonHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNgayGiaoHang.Text = dgvDonHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbShipperID.Text = dgvDonHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChiGiaoHang.Text= dgvDonHang.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtThanhPho.Text= dgvDonHang.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Order donHang = new Order();
            donHang.CustomerID = cbMaKhachHang.SelectedValue.ToString();
            donHang.EmployeeID = int.Parse(cbMaNhanVien.SelectedValue.ToString());
            donHang.OrderDate = dtpNgayDatHang.Value;
            donHang.ShippedDate = dtpNgayGiaoHang.Value;
            donHang.ShipperID = int.Parse(cbShipperID.SelectedValue.ToString());
            donHang.ShipAddress = txtDiaChiGiaoHang.Text;
            donHang.ShipCity = txtThanhPho.Text;
            if (dtpNgayDatHang.Value <= DateTime.Today && dtpNgayGiaoHang.Value >= dtpNgayDatHang.Value)
            {
                busDH.Them(donHang);
                HienThiDG();
            }
            else if (dtpNgayDatHang.Value > DateTime.Today)
                MessageBox.Show("Lỗi: Bạn đã nhập NGÀY ĐẶT HÀNG lớn hơn ngày hiện tại");
            else if (dtpNgayGiaoHang.Value < dtpNgayDatHang.Value)
                MessageBox.Show("Lỗi: Bạn đã nhập NGÀY GIAO HÀNG bé hơn ngày đặt hàng");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            while(txtMaDonHang.Text != "")
            {
                Order donHang = new Order();
                donHang.OrderID = int.Parse(txtMaDonHang.Text);
                donHang.CustomerID = cbMaKhachHang.SelectedValue.ToString();
                donHang.EmployeeID = int.Parse(cbMaNhanVien.SelectedValue.ToString());
                donHang.OrderDate = dtpNgayDatHang.Value;
                donHang.ShippedDate = dtpNgayGiaoHang.Value;
                donHang.ShipperID = int.Parse(cbShipperID.SelectedValue.ToString());
                donHang.ShipAddress = txtDiaChiGiaoHang.Text;
                donHang.ShipCity = txtThanhPho.Text;
                if (dtpNgayDatHang.Value <= DateTime.Today && dtpNgayGiaoHang.Value >= dtpNgayDatHang.Value)
                {
                    if (busDH.Sua(donHang))
                    {
                        HienThiDG();
                    }
                    else
                        MessageBox.Show("Lỗi: Sửa đơn hàng không thành công");
                }
                else if (dtpNgayDatHang.Value > DateTime.Today)
                    MessageBox.Show("Lỗi: Bạn đã nhập NGÀY ĐẶT HÀNG lớn hơn ngày hiện tại");
                else if (dtpNgayGiaoHang.Value < dtpNgayDatHang.Value)
                    MessageBox.Show("Lỗi: Bạn đã nhập NGÀY GIAO HÀNG bé hơn ngày đặt hàng");
                break;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            while (txtMaDonHang.Text != "")
            {
                Order dh = new Order();
                dh.OrderID = int.Parse(txtMaDonHang.Text);
                if (busDH.Xoa(dh))
                    HienThiDG();
                else
                    MessageBox.Show("Lỗi: Không xóa được đơn hàng");
                break;
            }
        }

        private void dgvDonHang_DoubleClick(object sender, EventArgs e)
        {
            //FDatHang f = new FDatHang();
            //f.maDH = int.Parse(dgvDonHang.CurrentRow.Cells["OrderID"].Value.ToString());
            //f.ShowDialog();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaDonHang.Clear();
            dtpNgayDatHang.Value = DateTime.Today;
            dtpNgayGiaoHang.Value = DateTime.Today;
            txtDiaChiGiaoHang.Clear();
            txtThanhPho.Clear();
        }
    }
}
