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
    public partial class FNhaCungCap : Form
    {
        BUS_DonHang busNCC;
        public FNhaCungCap()
        {
            InitializeComponent();
            busNCC = new BUS_DonHang();
        }
        private void HienThiDSNCClenDG()
        {
            gVNCC.DataSource = null;
            busNCC.NCC_LayDSNCC(gVNCC);
            gVNCC.Columns[0].Width = (int)(gVNCC.Width * 0.09);
            gVNCC.Columns[1].Width = (int)(gVNCC.Width * 0.16);
            gVNCC.Columns[2].Width = (int)(gVNCC.Width * 0.16);
            gVNCC.Columns[3].Width = (int)(gVNCC.Width * 0.16);
            gVNCC.Columns[4].Width = (int)(gVNCC.Width * 0.16);
            gVNCC.Columns[5].Width = (int)(gVNCC.Width * 0.16);
        }

        private void FNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDSNCClenDG();
        }

        private void gVNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVNCC.Rows.Count)
            {
                tbMaNCC.Text = gVNCC.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();
                tbTenCongTy.Text = gVNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbDiaChi.Text = gVNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbTP.Text = gVNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbQuocGia.Text = gVNCC.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbSDT.Text = gVNCC.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier NhaCungCap = new Supplier();
                //nhanVien.EmployeeID = Int32.Parse(txtMaNV.ToString());
                NhaCungCap.CompanyName = tbTenCongTy.Text;
                NhaCungCap.Address = tbDiaChi.Text;
                NhaCungCap.Country = tbQuocGia.Text;
                NhaCungCap.City = tbTP.Text;
                NhaCungCap.Phone = tbSDT.Text;
                if (busNCC.NCC_ThemNhaCungCap(NhaCungCap))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    busNCC.NCC_LayDSNCC(gVNCC);
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại");
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
                Supplier NhaCungCap = new Supplier();
                NhaCungCap.SupplierID = int.Parse(tbMaNCC.Text);
                NhaCungCap.CompanyName = tbTenCongTy.Text;
                NhaCungCap.Address = tbDiaChi.Text;
                NhaCungCap.City = tbTP.Text;
                NhaCungCap.Country = tbQuocGia.Text;
                NhaCungCap.Phone = tbSDT.Text;
                if (busNCC.NCC_SuaNCC(NhaCungCap))
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công");
                    busNCC.NCC_LayDSNCC(gVNCC);
                }
                else
                {
                    MessageBox.Show("Sửa nhà cung cấp thất bại");
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
                Supplier NhaCungCap = new Supplier();
                NhaCungCap.SupplierID = int.Parse(tbMaNCC.Text);
                if (busNCC.NCC_XoaNCC(NhaCungCap))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    busNCC.NCC_LayDSNCC(gVNCC);
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbMaNCC.Clear();
            tbTenCongTy.Clear();
            tbDiaChi.Clear();
            tbTP.Clear();
            tbQuocGia.Clear();
            tbSDT.Clear();
        }
    }
}
