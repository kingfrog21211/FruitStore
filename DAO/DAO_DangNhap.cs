using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_CUOIKY_NHOM4_IM81.DAO
{
    class DAO_DangNhap
    {
        FruitsStoreEntities2 db;
        public DAO_DangNhap()
        {
            db = new FruitsStoreEntities2();
        }
        public bool KiemTraDangNhap(User u)
        {
            bool? kq;
            kq = db.sp_DangNhap(u.UserID, u.Password).FirstOrDefault();
            return (bool)kq;
        }
        public void ChinhSua(User u)
        {
            User n = db.Users.Find(u.UserID);
            n.UserID = u.UserID;
            n.Password = u.Password;
            db.SaveChanges();
        }
    }
}
