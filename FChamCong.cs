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
    public partial class FChamCong : Form
    {
        BUS_DonHang busCC;
        public FChamCong()
        {
            InitializeComponent();
            busCC = new BUS_DonHang();
        }
        private void HienThiDG()
        {
            dgChamCong.DataSource = null;
            busCC.CC_LayDuLieuCC(dgChamCong);
            dgChamCong.Columns[0].Width = (int)(dgChamCong.Width * 0.15);
            dgChamCong.Columns[1].Width = (int)(dgChamCong.Width * 0.15);
            dgChamCong.Columns[2].Width = (int)(dgChamCong.Width * 0.15);
            dgChamCong.Columns[3].Width = (int)(dgChamCong.Width * 0.15);
            dgChamCong.Columns[4].Width = (int)(dgChamCong.Width * 0.1);
            dgChamCong.Columns[5].Width = (int)(dgChamCong.Width * 0.5);
        }
        private void ComboBoxMaNV()
        {
            busCC.CC_ComboBoxMaNV(cbMaNV);
        }

        private void FChamCong_Load(object sender, EventArgs e)
        {
            HienThiDG();
            ComboBoxMaNV();
            txtTenNV.Text = cbMaNV.SelectedValue.ToString();
            txtTongGio.Text = "0";
        }

        private void rbVao7h_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRa12h.Checked)
                txtTongGio.Text = "5";
            else if (rbRa17h.Checked)
                txtTongGio.Text = "10";
            else if (rbRa22h.Checked)
                txtTongGio.Text = "15";
        }

        private void rbVao12h_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRa12h.Checked)
                txtTongGio.Text = "0";
            else if (rbRa17h.Checked)
                txtTongGio.Text = "5";
            else if (rbRa22h.Checked)
                txtTongGio.Text = "10";
        }

        private void rbVao17h_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRa12h.Checked || rbRa17h.Checked)
                txtTongGio.Text = "0";
            else if (rbRa22h.Checked)
                txtTongGio.Text = "5";
        }

        private void rbRa12h_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVao7h.Checked)
                txtTongGio.Text = "5";
            else if (rbVao12h.Checked || rbVao17h.Checked)
                txtTongGio.Text = "0";
        }

        private void rbRa17h_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVao7h.Checked)
                txtTongGio.Text = "10";
            else if (rbVao12h.Checked)
                txtTongGio.Text = "5";
            else if (rbVao17h.Checked)
                txtTongGio.Text = "0";
        }

        private void rbRa22h_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVao7h.Checked)
                txtTongGio.Text = "15";
            else if (rbVao12h.Checked)
                txtTongGio.Text = "10";
            else if (rbVao17h.Checked)
                txtTongGio.Text = "5";
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = cbMaNV.SelectedValue.ToString();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTongGio.Text != "0")
                {
                    TimeSheet t = new TimeSheet();
                    t.WorkDate = DateTime.Parse(dtpNgayLam.Value.ToShortDateString());
                    t.EmployeeID = int.Parse(cbMaNV.Text);
                    //time from
                    if (rbVao7h.Checked)
                        t.TimeFrom = rbVao7h.Text;
                    else if (rbVao12h.Checked)
                        t.TimeFrom = rbVao12h.Text;
                    else if (rbVao17h.Checked)
                        t.TimeFrom = rbVao17h.Text;
                    //time to
                    if (rbRa12h.Checked)
                        t.TimeTo = rbRa12h.Text;
                    else if (rbRa17h.Checked)
                        t.TimeTo = rbRa17h.Text;
                    else if (rbRa22h.Checked)
                        t.TimeTo = rbRa22h.Text;
                    t.Hours = int.Parse(txtTongGio.Text);
                    t.Notes = txtGhiChu.Text;
                    if (dtpNgayLam.Value > DateTime.Today)
                        MessageBox.Show("Lỗi: NGÀY LÀM không được lớn hơn ngày hiện tại");
                    else
                    {
                        busCC.CC_Them(t);
                        HienThiDG();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DateTime ngayTam;
        int maTam;
        private void dgChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgChamCong.Rows.Count)
            {
                dtpNgayLam.Text = dgChamCong.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbMaNV.Text = dgChamCong.Rows[e.RowIndex].Cells[1].Value.ToString();
                maTam = int.Parse(dgChamCong.Rows[e.RowIndex].Cells[1].Value.ToString());
                ngayTam = DateTime.Parse(dgChamCong.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtGhiChu.Text = dgChamCong.Rows[e.RowIndex].Cells[5].Value.ToString();
                //radiobutton
                string tgVao, tgRa;
                tgVao = dgChamCong.Rows[e.RowIndex].Cells[2].Value.ToString();
                tgRa = dgChamCong.Rows[e.RowIndex].Cells[3].Value.ToString();
                //time vào
                if (tgVao == "7h00")
                    rbVao7h.Checked = true;
                else if (tgVao == "12h00")
                    rbVao12h.Checked = true;
                else if (tgVao == "17h00")
                    rbVao17h.Checked = true;
                //time ra
                if (tgRa == "12h00")
                    rbRa12h.Checked = true;
                else if (tgRa == "17h00")
                    rbRa17h.Checked = true;
                else if (tgRa == "22h00")
                    rbRa22h.Checked = true;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTongGio.Text != "0")
                {
                    TimeSheet t = new TimeSheet();
                    t.WorkDate = dtpNgayLam.Value;
                    t.EmployeeID = int.Parse(cbMaNV.Text);
                    //time from
                    if (rbVao7h.Checked)
                        t.TimeFrom = rbVao7h.Text;
                    else if (rbVao12h.Checked)
                        t.TimeFrom = rbVao12h.Text;
                    else if (rbVao17h.Checked)
                        t.TimeFrom = rbVao17h.Text;
                    //time to
                    if (rbRa12h.Checked)
                        t.TimeTo = rbRa12h.Text;
                    else if (rbRa17h.Checked)
                        t.TimeTo = rbRa17h.Text;
                    else if (rbRa22h.Checked)
                        t.TimeTo = rbRa22h.Text;
                    t.Hours = int.Parse(txtTongGio.Text);
                    t.Notes = txtGhiChu.Text;
                    if (dtpNgayLam.Value > DateTime.Today)
                        MessageBox.Show("Lỗi: NGÀY LÀM không được lớn hơn ngày hiện tại");
                    else
                    {
                        busCC.CC_Sua(t, ngayTam, maTam);
                        HienThiDG();
                    }
                }
                else MessageBox.Show("Tổng số giờ đang bằng 0!!");
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
                TimeSheet t = new TimeSheet();
                t.WorkDate = DateTime.Parse(dgChamCong.CurrentRow.Cells[0].Value.ToString());
                t.EmployeeID = int.Parse(dgChamCong.CurrentRow.Cells[1].Value.ToString());
                busCC.CC_Xoa(t);
                HienThiDG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
