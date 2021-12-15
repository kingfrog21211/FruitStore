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
    public partial class FDonViVanChuyen : Form
    {
        BUS_DonHang busVC;
        public FDonViVanChuyen()
        {
            InitializeComponent();
            busVC = new BUS_DonHang();
        }
        private void HienThiDSDVVC()
        {
            gVDVVC.DataSource = null;
            busVC.DVVC_LayDSDVVC(gVDVVC);
            gVDVVC.Columns[0].Width = (int)(gVDVVC.Width * 0.2);
            gVDVVC.Columns[1].Width = (int)(gVDVVC.Width * 0.4);
            gVDVVC.Columns[2].Width = (int)(gVDVVC.Width * 0.4);
        }

        private void FDonViVanChuyen_Load(object sender, EventArgs e)
        {
            HienThiDSDVVC();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                Shipper p = new Shipper();
                p.CompanyName = txtCompanyName.Text;
                p.Phone = txtPhone.Text;
                if (busVC.DVVC_ThemDVVC(p))
                {
                    MessageBox.Show("Thêm thành công");
                    busVC.DVVC_LayDSDVVC(gVDVVC);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
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
                Shipper p = new Shipper();
                p.ShipperID = int.Parse(txtMaShipper.Text);
                if (busVC.DVVC_XoaDVVC(p))
                {
                    MessageBox.Show("Xóa thành công");
                    busVC.DVVC_LayDSDVVC(gVDVVC);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
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
                Shipper p = new Shipper();
                p.ShipperID = int.Parse(txtMaShipper.Text);
                p.CompanyName = txtCompanyName.Text;
                p.Phone = txtPhone.Text;
                if (busVC.DVVC_SuaDVVC(p))
                {
                    MessageBox.Show("Sửa thành công");
                    busVC.DVVC_LayDSDVVC(gVDVVC);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gVDVVC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDVVC.Rows.Count)
            {
                txtMaShipper.Text = gVDVVC.Rows[e.RowIndex].Cells["ShipperID"].Value.ToString();
                txtCompanyName.Text = gVDVVC.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = gVDVVC.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaShipper.Clear();
            txtCompanyName.Clear();
            txtPhone.Clear();
        }
    }
}
