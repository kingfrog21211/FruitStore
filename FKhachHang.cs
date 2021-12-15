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
    public partial class FKhachHang : Form
    {
        BUS_DonHang busDonHang;
        public FKhachHang()
        {
            InitializeComponent();
            busDonHang = new BUS_DonHang();
        }
        private void HienThiDSKhachHang()
        {
            gVDSKH.DataSource = null;
            busDonHang.KH_HienThiDSKhachHang(gVDSKH);
            gVDSKH.Columns[0].Width = (int)(gVDSKH.Width * 0.1);
            gVDSKH.Columns[1].Width = (int)(gVDSKH.Width * 0.2);
            gVDSKH.Columns[2].Width = (int)(gVDSKH.Width * 0.2);
            gVDSKH.Columns[3].Width = (int)(gVDSKH.Width * 0.2);
            gVDSKH.Columns[4].Width = (int)(gVDSKH.Width * 0.2);
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }
        string tam = "";
        private void gVDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDSKH.Rows.Count)
            {
                txtMaKH.Text = gVDSKH.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                txtTenKH.Text = gVDSKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = gVDSKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTPho.Text = gVDSKH.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = gVDSKH.Rows[e.RowIndex].Cells[4].Value.ToString();
                tam = gVDSKH.CurrentRow.Cells["CustomerID"].Value.ToString();//lưu CustomerID cũ
            }
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer();
                c.CustomerID = txtMaKH.Text;
                c.CustomerName = txtTenKH.Text;
                c.Address = txtDiaChi.Text;
                c.City = txtTPho.Text;
                c.Phone = txtSDT.Text;
                if (busDonHang.KH_Them(c))
                {
                    MessageBox.Show("Tạo khách hàng thành công!");
                    HienThiDSKhachHang();
                }
                else
                    MessageBox.Show("Tạo khách hàng thất bại!");
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
                Customer c = new Customer();
                c.CustomerID = tam;//CustomerID mới
                c.CustomerName = txtTenKH.Text;
                c.Address = txtDiaChi.Text;
                c.City = txtTPho.Text;
                c.Phone = txtSDT.Text;
                if (busDonHang.KH_Sua(c))
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    HienThiDSKhachHang();
                }
                else
                    MessageBox.Show("Sửa khách hàng thất bại!");
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
                Customer c = new Customer();
                c.CustomerID = txtMaKH.Text.ToString();
                if (busDonHang.KH_Xoa(c))
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    HienThiDSKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtTPho.Clear();
            txtSDT.Clear();
        }
    }
}
