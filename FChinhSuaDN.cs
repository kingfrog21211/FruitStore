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
    public partial class FChinhSuaDN : Form
    {
        BUS_DangNhap busDN;
        public FChinhSuaDN()
        {
            InitializeComponent();
            busDN = new BUS_DangNhap();
        }
        public string id;
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.UserID = id;
                u.Password = int.Parse(txtPass.Text);
                busDN.ChinhSua(u);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
