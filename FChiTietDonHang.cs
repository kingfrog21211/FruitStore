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
    public partial class FChiTietDonHang : Form
    {
        BUS_DonHang busDH;
        bool co = false;
        int maDH;
        public FChiTietDonHang()
        {
            InitializeComponent();
            busDH = new BUS_DonHang();
        }
        private void ComboBoxDH()
        {
            busDH.HienThiCBMaDH(cbMaDonHang);
        }
        private void HienThiDG(int ma)
        {
            dgvChiTietDonHang.DataSource = null;
            busDH.HienThiCTDH(ma, dgvChiTietDonHang);
            //kich thuoc
            dgvChiTietDonHang.Columns[0].Width = (int)(dgvChiTietDonHang.Width * 0.1);
            dgvChiTietDonHang.Columns[1].Width = (int)(dgvChiTietDonHang.Width * 0.2);
            dgvChiTietDonHang.Columns[2].Width = (int)(dgvChiTietDonHang.Width * 0.2);
            dgvChiTietDonHang.Columns[3].Width = (int)(dgvChiTietDonHang.Width * 0.2);
            dgvChiTietDonHang.Columns[4].Width = (int)(dgvChiTietDonHang.Width * 0.1);
            dgvChiTietDonHang.Columns[5].Width = (int)(dgvChiTietDonHang.Width * 0.15);
        }
        private void FChiTietDonHang_Load(object sender, EventArgs e)
        {
            //ComboBoxDH();
            //co = true;
            //maDH = int.Parse(cbMaDonHang.SelectedValue.ToString());
            //HienThiDG(maDH);
        }

        private void cbMaDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (co == true)
                maDH = int.Parse(cbMaDonHang.SelectedValue.ToString());
            HienThiDG(maDH);
        }
        int tam;
        private void dgvChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSP.Text = dgvChiTietDonHang.CurrentRow.Cells["ProductName"].Value.ToString();
            txtDonGia.Text = dgvChiTietDonHang.CurrentRow.Cells["UnitPrice"].Value.ToString();
            txtSoLuong.Text = dgvChiTietDonHang.CurrentRow.Cells["Quantity"].Value.ToString();
            txtGiamGia.Text = dgvChiTietDonHang.CurrentRow.Cells["Discount"].Value.ToString();
            tam = int.Parse(dgvChiTietDonHang.CurrentRow.Cells["ProductID"].Value.ToString());
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FDatHang f = new FDatHang();
            f.maDH = int.Parse(cbMaDonHang.SelectedValue.ToString());
            f.ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSoLuong.Text) > 0 && float.Parse(txtGiamGia.Text) >= 0.00)
                {
                    OrderDetail donHang = new OrderDetail();
                    donHang.OrderID = maDH;
                    donHang.ProductID = tam;
                    donHang.Quantity = short.Parse(txtSoLuong.Text);
                    donHang.Discount = float.Parse(txtGiamGia.Text);
                    busDH.Sua1(donHang);
                    HienThiDG(maDH);
                }
                else if (int.Parse(txtSoLuong.Text) <= 0)
                    MessageBox.Show("Lỗi: Số lượng phải lớn hơn 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            OrderDetail donHang = new OrderDetail();
            donHang.OrderID = maDH;
            donHang.ProductID = int.Parse(dgvChiTietDonHang.CurrentRow.Cells["ProductID"].Value.ToString());
            busDH.Xoa1(donHang);
            HienThiDG(maDH);
        }

        private void FChiTietDonHang_Activated(object sender, EventArgs e)
        {
            ComboBoxDH();
            co = true;
            maDH = int.Parse(cbMaDonHang.SelectedValue.ToString());
            HienThiDG(maDH);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSoLuong.Text = "1";
            txtGiamGia.Text = "0.00";
        }
    }
}
