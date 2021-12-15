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
    public partial class FNhanVien : Form
    {
        BUS_DonHang busNV;
        public FNhanVien()
        {
            InitializeComponent();
            busNV = new BUS_DonHang();
        }
        private void HienThiDSNhanVien()
        {
            dGVNV.DataSource = null;
            busNV.LayDSNhanVien(dGVNV);
            dGVNV.Columns[0].Width = (int)(dGVNV.Width * 0.1);
            dGVNV.Columns[1].Width = (int)(dGVNV.Width * 0.1);
            dGVNV.Columns[2].Width = (int)(dGVNV.Width * 0.1);
            dGVNV.Columns[3].Width = (int)(dGVNV.Width * 0.1);
            dGVNV.Columns[4].Width = (int)(dGVNV.Width * 0.2);
            dGVNV.Columns[5].Width = (int)(dGVNV.Width * 0.2);
            dGVNV.Columns[6].Width = (int)(dGVNV.Width * 0.2);
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVien();
        }

        private void dGVNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVNV.Rows.Count)
            {
                txtMaNV.Text = dGVNV.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtTenNV.Text = dGVNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHoNV.Text = dGVNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dGVNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChiNV.Text = dGVNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTPNV.Text = dGVNV.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSDTNV.Text = dGVNV.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Employee nhanVien = new Employee();
                //nhanVien.EmployeeID = Int32.Parse(txtMaNV.ToString());
                nhanVien.FirstName = txtTenNV.Text;
                nhanVien.LastName = txtHoNV.Text;
                nhanVien.BirthDate = dtpNgaySinh.Value;
                nhanVien.Address = txtDiaChiNV.Text;
                nhanVien.City = txtTPNV.Text;
                nhanVien.Homephone = txtSDTNV.Text;
                if (busNV.ThemNhanVien(nhanVien))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    busNV.LayDSNhanVien(dGVNV);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
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
                Employee nhanVien = new Employee();
                nhanVien.EmployeeID = int.Parse(txtMaNV.Text);
                nhanVien.FirstName = txtTenNV.Text;
                nhanVien.LastName = txtHoNV.Text;
                nhanVien.BirthDate = dtpNgaySinh.Value;
                nhanVien.Address = txtDiaChiNV.Text;
                nhanVien.City = txtTPNV.Text;
                nhanVien.Homephone = txtSDTNV.Text;
                if (busNV.SuaNV(nhanVien))
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                    busNV.LayDSNhanVien(dGVNV);
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Employee nhanVien = new Employee();
                nhanVien.EmployeeID = int.Parse(txtMaNV.Text);
                if (busNV.XoaNV(nhanVien))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    busNV.LayDSNhanVien(dGVNV);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtHoNV.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            txtDiaChiNV.Clear();
            txtTPNV.Clear();
        }
    }
}
