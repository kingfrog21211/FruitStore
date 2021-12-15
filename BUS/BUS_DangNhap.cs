using DOAN_CUOIKY_NHOM4_IM81.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_CUOIKY_NHOM4_IM81.BUS
{
    class BUS_DangNhap
    {
        DAO_DangNhap daoDN;
        public BUS_DangNhap()
        {
            daoDN = new DAO_DangNhap();
        }
        public bool KiemTraDangNhap(string id, int pass)
        {
            User u = new User();
            u.UserID = id;
            u.Password = pass;
            if (daoDN.KiemTraDangNhap(u) == true)
                return true;
            else
                return false;
        }
        public void ChinhSua(User u)
        {
            daoDN.ChinhSua(u);
            MessageBox.Show("Thành công!");
        }
    }
}
