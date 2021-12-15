using DOAN_CUOIKY_NHOM4_IM81.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DOAN_CUOIKY_NHOM4_IM81.BUS
{
    class BUS_DonHang
    {
        DAO_DonHang daoDH;
        public BUS_DonHang()
        {
            daoDH = new DAO_DonHang();
        }
        //FDonHang
        public void HienThiDGDonHang(DataGridView dg)
        {
            dg.DataSource = daoDH.LayDSDonHang();
        }
        public void HienThiCBKhachHang(ComboBox cb)
        {
            cb.DataSource = daoDH.LayDSKhachHang();
            cb.DisplayMember = "CustomerID";
            cb.ValueMember = "CustomerID";
        }
        public void HienThiCBNhanVien(ComboBox cb)
        {
            cb.DataSource = daoDH.LayDSNhanVien();
            cb.DisplayMember = "EmployeeID";
            cb.ValueMember = "EmployeeID";
        }
        public void HienThiCBShipper(ComboBox cb)
        {
            cb.DataSource = daoDH.LayDSShipper();
            cb.DisplayMember = "ShipperID";
            cb.ValueMember = "ShipperID";
        }
        public void Them(Order dh)
        {
            daoDH.them(dh);
        }
        public bool Sua(Order o)
        {
            try
            {
                daoDH.sua(o);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool Xoa(Order d)
        {
            try
            {
                daoDH.xoa(d);
                return true;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //FChiTietDonHang: 1
        public void HienThiCTDH(int maDH, DataGridView dg)
        {
            dg.DataSource = daoDH.LayCTDH(maDH);
        }
        public void HienThiCBMaDH(ComboBox cb)
        {
            cb.DataSource = daoDH.LayDSDH();
            cb.DisplayMember = "OrderID";
            cb.ValueMember = "OrderID";
        }
        public void Sua1(OrderDetail dh)
        {
            if (daoDH.sua1(dh))
                MessageBox.Show("Sửa thành công");
        }
        public void Xoa1(OrderDetail dh)
        {
            try
            {
                daoDH.xoa1(dh);
                MessageBox.Show("Xóa thành công");
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        //FDatHang
        public Product LayThongTinSP(int maSP)
        {
            return daoDH.LayTTSP(maSP);
        }
        public void HienThiCBSanPham(ComboBox cb)
        {
            cb.DataSource = daoDH.LayDSSP();
            cb.DisplayMember = "ProductName";
            cb.ValueMember = "ProductID";
        }
        public bool DatHang(DataTable tb, int ma)
        {
            bool kq = false;
            using (var tran = new TransactionScope())
            {
                try
                {
                    foreach (DataRow i in tb.Rows)
                    {
                        OrderDetail d1 = new OrderDetail();
                        d1.OrderID = ma;
                        d1.ProductID = int.Parse(i["ProductID"].ToString());
                        d1.UnitPrice = decimal.Parse(i["UnitPrice"].ToString());
                        d1.Quantity = short.Parse(i["Quantity"].ToString());
                        d1.Discount = Single.Parse(i["Discount"].ToString());
                        if (daoDH.KiemTraSPDonHang(d1))
                        {
                            daoDH.ThemCTDH(d1);
                        }
                        else
                            throw new Exception("Mã Sản phẩm '" + d1.ProductID + "' đã tồn tại");
                    }
                    tran.Complete();
                    kq = true;
                }
                catch (Exception e)
                {
                    kq = false;
                    MessageBox.Show(e.Message);
                }
            }
            return kq;
        }

        //FSanPham
        public void HienThiDSSanPham(DataGridView dg)
        {
            dg.DataSource = daoDH.SP_LayDSSanPham();
        }
        public void HienThiCBMaNCC(ComboBox cb)
        {
            cb.DataSource = daoDH.SP_LayDSNCC();
            cb.DisplayMember = "SupplierID";
            cb.ValueMember = "SupplierID";
        }
        public bool SP_Them(Product p)
        {
            try
            {
                daoDH.SP_ThemSanPham(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SP_Sua(Product p)
        {
            if (daoDH.SP_KiemTraSP(p))
            {
                try
                {
                    daoDH.SP_SuaSanPham(p);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
        public bool SP_Xoa(Product p)
        {
            if (daoDH.SP_KiemTraSP(p))
            {
                try
                {
                    daoDH.SP_XoaSanPham(p);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }

        //FKhachHang
        public void KH_HienThiDSKhachHang(DataGridView dg)
        {
            dg.DataSource = daoDH.KH_LayDSKH();
        }
        public bool KH_Them(Customer c)
        {
            try
            {
                daoDH.KH_ThemKH(c);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool KH_Sua(Customer c)
        {
            //if (daoDH.KH_KiemTraKH(c))
            //{
                try
                {
                    daoDH.KH_SuaKH(c);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            //}
            //else
            //    return false;
        }
        public bool KH_Xoa(Customer c)
        {
            if (daoDH.KH_KiemTraKH(c))
            {
                try
                {
                    daoDH.KH_XoaKH(c);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }

        //FNhanVien
        public void LayDSNhanVien(DataGridView dg)
        {
            dg.DataSource = daoDH.NV_LayDSNhanVien();
        }
        public bool ThemNhanVien(Employee e)
        {
            try
            {
                daoDH.NV_ThemNhanVien(e);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaNV(Employee e)
        {
            if (daoDH.NV_KiemTraNV(e))
            {
                try
                {
                    daoDH.NV_SuaNV(e);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool XoaNV(Employee e)
        {
            if (daoDH.NV_KiemTraNV(e))
            {
                try
                {
                    daoDH.NV_XoaNV(e);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //FNhaCungCap
        public void NCC_LayDSNCC(DataGridView dg)
        {
            dg.DataSource = daoDH.NCC_LayDSSNCC();
        }
        public bool NCC_ThemNhaCungCap(Supplier e)
        {
            try
            {
                daoDH.NCC_ThemNhaCungCap(e);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool NCC_SuaNCC(Supplier e)
        {
            if (daoDH.NCC_KiemTraNCC(e))
            {
                try
                {
                    daoDH.NCC_SuaNCC(e);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool NCC_XoaNCC(Supplier e)
        {
            if (daoDH.NCC_KiemTraNCC(e))
            {
                try
                {
                    daoDH.NCC_XoaNCC(e);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //FDonViVanChuyen
        public void DVVC_LayDSDVVC(DataGridView dg)
        {
            dg.DataSource = daoDH.DVVC_LayDSDVVC();
        }

        public bool DVVC_ThemDVVC(Shipper p)
        {
            try
            {
                daoDH.DVVC_ThemDVVC(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DVVC_SuaDVVC(Shipper p)
        {

            if (daoDH.DVVC_KiemTraDVVC(p))
            {
                try
                {
                    daoDH.DVVC_SuaDVVC(p);
                    return true;
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public bool DVVC_XoaDVVC(Shipper p)
        {
            if (daoDH.DVVC_KiemTraDVVC(p))
            {
                try
                {
                    daoDH.DVVC_XoaDVVC(p);
                    return true;
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }

        //FChamCong
        public void CC_LayDuLieuCC(DataGridView dg)
        {
            dg.DataSource = daoDH.CC_LayDuLieuCC();
        }
        public void CC_ComboBoxMaNV(ComboBox cb)
        {
            cb.DataSource = daoDH.CC_LayMaNV();
            cb.DisplayMember = "EmployeeID";
            cb.ValueMember = "LastName";
        }
        public void CC_Them(TimeSheet t)
        {
            daoDH.CC_them(t);
        }
        public void CC_Sua(TimeSheet t, DateTime ngayCu, int idCu)
        {
            if (daoDH.CC_sua(t, ngayCu, idCu))
                MessageBox.Show("Đã sửa!");
        }
        public void CC_Xoa(TimeSheet t)
        {
            try
            {
                daoDH.CC_xoa(t);
                MessageBox.Show("Đã xóa!");
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
    }
}
