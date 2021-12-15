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
    public partial class FDangNhap : Form
    {
        BUS_DangNhap busDN;
        public FDangNhap()
        {
            InitializeComponent();
            busDN = new BUS_DangNhap();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "" && txtPassword.Text != "")
            {
                if (busDN.KiemTraDangNhap(txtUserID.Text, int.Parse(txtPassword.Text)) == true)
                {
                    txtUserID.Text = "";
                    txtPassword.Text = "";
                    FManHinhChinh f = new FManHinhChinh();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Sai thông tin tài khoản!");
            }
            else
                MessageBox.Show("Chưa điền đủ thông tin đăng nhập!");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btDoi_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "" && txtPassword.Text != "")
            {
                string id = txtUserID.Text;
                int pass = int.Parse(txtPassword.Text);
                if (busDN.KiemTraDangNhap(id, pass))
                {
                    FChinhSuaDN f = new FChinhSuaDN();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.id = this.txtUserID.Text;
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Sai thông tin tài khoản!");
            }
            else
                MessageBox.Show("Chưa điền đủ thông tin đăng nhập!");
        }
    }
}
