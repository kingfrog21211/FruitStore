using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_CUOIKY_NHOM4_IM81.DAO
{
    class DAO_DonHang
    {
        FruitsStoreEntities2 db;
        public DAO_DonHang()
        {
            db = new FruitsStoreEntities2();
        }
        //FDonHang
        public dynamic LayDSDonHang()
        {
            var ds = db.Orders.Select(s => new
            {
                s.OrderID,
                s.CustomerID,
                s.EmployeeID,
                s.OrderDate,
                s.ShippedDate,
                s.ShipperID,
                s.ShipAddress,
                s.ShipCity
            }).ToList();
            return ds;
        }
        public dynamic LayDSKhachHang()
        {
            var ds = db.Customers.Select(s => new { s.CustomerID }).ToList();
            return ds;
        }
        public dynamic LayDSNhanVien()
        {
            var ds = db.Employees.Select(s => new { s.EmployeeID }).ToList();
            return ds;
        }
        public dynamic LayDSShipper()
        {
            var ds = db.Shippers.Select(s => new { s.ShipperID }).ToList();
            return ds;
        }
        public void them(Order dh)
        {
            try
            {
                db.Orders.Add(dh);
                db.SaveChanges();
                MessageBox.Show("Thêm đơn hàng thành công!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void sua(Order o)
        {
            try
            {
                Order donHang;
                donHang = db.Orders.Find(o.OrderID);
                donHang.CustomerID = o.CustomerID;
                donHang.EmployeeID = o.EmployeeID;
                donHang.OrderDate = o.OrderDate;
                donHang.ShippedDate = o.ShippedDate;
                donHang.ShipperID = o.ShipperID;
                donHang.ShipAddress = o.ShipAddress;
                donHang.ShipCity = o.ShipCity;
                db.SaveChanges();
                MessageBox.Show("Sửa đơn hàng thành công!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void xoa(Order d)
        {
            try
            {
                Order donHang;
                donHang = db.Orders.Find(d.OrderID);
                db.Orders.Remove(donHang);
                db.SaveChanges();
                MessageBox.Show("Xóa đơn hàng thành công!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //FChiTietDonHang
        public dynamic LayCTDH(int maDH)
        {
            var ds = db.OrderDetails.Where(s => s.OrderID == maDH).Select(s => new
            {
                s.OrderID,
                s.ProductID,
                s.Product.ProductName,
                s.UnitPrice,
                s.Quantity,
                s.Discount
            }).ToList();
            return ds;
        }
        public dynamic LayDSDH()
        {
            var ds = db.Orders.Select(s => new { s.OrderID }).ToList();
            return ds;
        }
        public bool sua1(OrderDetail dh)
        {
            bool trangThai = false;
            try
            {
                OrderDetail d = new OrderDetail();
                //d.OrderID = dh.OrderID;
                d = db.OrderDetails.Single(s => s.ProductID == dh.ProductID && s.OrderID == dh.OrderID);
                d.Quantity = dh.Quantity;
                d.Discount = dh.Discount;

                db.SaveChanges();
                trangThai = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                trangThai = false;
            }
            return trangThai;
        }
        public void xoa1(OrderDetail dh)
        {
            var d = db.OrderDetails.Single(s => s.ProductID == dh.ProductID && s.OrderID == dh.OrderID); //co 2 khoa ngoai
            db.OrderDetails.Remove(d);
            db.SaveChanges();
        }

        //FDatHang
        public Product LayTTSP(int maSP)
        {
            Product sp = db.Products.FirstOrDefault(s => s.ProductID == maSP);
            return sp;
        }
        public dynamic LayDSSP()
        {
            var ds=db.Products.Select(s => new { s.ProductID, s.ProductName }).ToList();
            return ds;
        }
        public bool KiemTraSPDonHang(OrderDetail dh)
        {
            int? sl;
            sl = db.sp_KiemTraSPDonHang(dh.OrderID, dh.ProductID).FirstOrDefault();
            if (sl != 0)
                return false;
            else
                return true;
        }
        public void ThemCTDH(OrderDetail dh)
        {
            db.OrderDetails.Add(dh);
            db.SaveChanges();
        }

        //FSanPham
        public dynamic SP_LayDSSanPham()
        {
            var ds = db.Products.Select(s => new
            {
                s.ProductID,
                s.ProductName,
                s.SupplierID,
                s.UnitPrice,
                s.UnitInStock
            }).ToList();
            return ds;
        }
        public dynamic SP_LayDSNCC()
        {
            var ds = db.Suppliers.Select(s => new { s.SupplierID }).ToList();
            return ds;
        }
        public void SP_ThemSanPham(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }
        public bool SP_KiemTraSP(Product p)
        {
            Product o = db.Products.Find(p.ProductID);
            if (p != null)
            {
                return true;
            }
            else
                return false;
        }
        public void SP_SuaSanPham(Product p)
        {
            Product o = db.Products.Find(p.ProductID);
            o.ProductName = p.ProductName;
            o.SupplierID = p.SupplierID;
            o.UnitPrice = p.UnitPrice;
            o.UnitInStock = p.UnitInStock;
            db.SaveChanges();
        }
        public void SP_XoaSanPham(Product p)
        {
            Product o = db.Products.Find(p.ProductID);
            db.Products.Remove(o);
            db.SaveChanges();
        }

        //FKhachHang
        public dynamic KH_LayDSKH()
        {
            var ds = db.Customers.Select(s => new
            {
                s.CustomerID,
                s.CustomerName,
                s.Address,
                s.City,
                s.Phone
            }).ToList();
            return ds;
        }
        public void KH_ThemKH(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
        }
        public bool KH_KiemTraKH(Customer c)
        {
            Customer o = db.Customers.Find(c.CustomerID);
            if (c != null)
                return true;
            else
                return false;
        }
        public void KH_SuaKH(Customer c)
        {
            Customer o = db.Customers.Find(c.CustomerID);
            //o.CustomerID = c.CustomerID;
            o.CustomerName = c.CustomerName;
            o.Address = c.Address;
            o.City = c.City;
            o.Phone = c.Phone;
            db.SaveChanges();
        }
        public void KH_XoaKH(Customer c)
        {
            Customer o = db.Customers.Find(c.CustomerID);
            db.Customers.Remove(o);
            db.SaveChanges();
        }

        //FNhanVien
        public dynamic NV_LayDSNhanVien()
        {
            var ds = db.Employees.Select(s => new
            {
                s.EmployeeID,
                s.FirstName,
                s.LastName,
                s.BirthDate,
                s.Address,
                s.City,
                s.Homephone
            }).ToList();
            return ds;
        }
        public void NV_ThemNhanVien(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }
        public bool NV_KiemTraNV(Employee e)
        {
            Employee d = db.Employees.Find(e.EmployeeID);
            if (e != null)
            {
                return true;
            }
            else
                return false;
        }
        public void NV_SuaNV(Employee e)
        {
            Employee d = db.Employees.Find(e.EmployeeID);
            d.FirstName = e.FirstName;
            d.LastName = e.LastName;
            d.BirthDate = e.BirthDate;
            d.Address = e.Address;
            d.City = e.City;
            d.Homephone = e.Homephone;
            db.SaveChanges();
        }
        public void NV_XoaNV(Employee e)
        {
            Employee o = db.Employees.Find(e.EmployeeID);
            db.Employees.Remove(o);
            db.SaveChanges();
        }

        //FNhaCungCap
        public dynamic NCC_LayDSSNCC()
        {
            var ds = db.Suppliers.Select(s => new
            {
                s.SupplierID,
                s.CompanyName,
                s.Address,
                s.City,
                s.Country,
                s.Phone
            }).ToList();
            return ds;
        }
        public void NCC_ThemNhaCungCap(Supplier e)
        {
            db.Suppliers.Add(e);
            db.SaveChanges();
        }
        public bool NCC_KiemTraNCC(Supplier e)
        {
            Supplier d = db.Suppliers.Find(e.SupplierID);
            if (e != null)
            {
                return true;
            }
            else
                return false;
        }
        public void NCC_SuaNCC(Supplier e)
        {
            Supplier d = db.Suppliers.Find(e.SupplierID);
            d.CompanyName = e.CompanyName;
            d.Address = e.Address;
            d.City = e.City;
            d.Country = e.Country;
            d.Phone = e.Phone;
            db.SaveChanges();
        }
        public void NCC_XoaNCC(Supplier e)
        {
            Supplier o = db.Suppliers.Find(e.SupplierID);
            db.Suppliers.Remove(o);
            db.SaveChanges();
        }

        //FDonViVanChuyen
        public dynamic DVVC_LayDSDVVC()
        {
            var ds = db.Shippers.Select(s => new
            {
                s.ShipperID,
                s.CompanyName,
                s.Phone
            }).ToList();
            return ds;
        }

        public void DVVC_ThemDVVC(Shipper p)
        {

            db.Shippers.Add(p);
            db.SaveChanges();
        }

        public bool DVVC_KiemTraDVVC(Shipper p)
        {
            Shipper s = db.Shippers.Find(p.ShipperID);
            if (p != null)
            {
                return true;
            }
            else
                return false;
        }

        public void DVVC_SuaDVVC(Shipper p)
        {
            Shipper s = db.Shippers.Find(p.ShipperID);
            s.CompanyName = p.CompanyName;
            s.Phone = p.Phone;
            db.SaveChanges();
        }

        public void DVVC_XoaDVVC(Shipper p)
        {
            Shipper s = db.Shippers.Find(p.ShipperID);
            db.Shippers.Remove(s);
            db.SaveChanges();
        }

        //FChamCong
        public dynamic CC_LayDuLieuCC()
        {
            var ds = db.TimeSheets.Select(s => new
            {
                s.WorkDate,
                s.EmployeeID,
                s.TimeFrom,
                s.TimeTo,
                s.Hours,
                s.Notes
            }).ToList();
            return ds;
        }
        public dynamic CC_LayMaNV()
        {
            var ds = db.Employees.Select(s => new { s.EmployeeID, s.LastName }).ToList();
            return ds;
        }
        public void CC_them(TimeSheet t)
        {
            try
            {
                db.TimeSheets.Add(t);
                db.SaveChanges();
                MessageBox.Show("Thành công!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }
        public bool CC_sua(TimeSheet t, DateTime ngayCu, int idCu)
        {
            bool trangThai = false;
            try
            {
                TimeSheet d = new TimeSheet();
                d = db.TimeSheets.Single(s => s.WorkDate == ngayCu && s.EmployeeID == idCu);
                d.WorkDate = t.WorkDate;
                d.EmployeeID = t.EmployeeID;
                d.TimeFrom = t.TimeFrom;
                d.TimeTo = t.TimeTo;
                d.Hours = t.Hours;
                d.Notes = t.Notes;
                db.SaveChanges();
                trangThai = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                trangThai = false;
            }
            return trangThai;
        }
        public void CC_xoa(TimeSheet t)
        {
            var d = db.TimeSheets.Single(s => s.WorkDate == t.WorkDate && s.EmployeeID == t.EmployeeID);
            db.TimeSheets.Remove(d);
            db.SaveChanges();
        }
    }
}
