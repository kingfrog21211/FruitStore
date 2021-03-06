//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOAN_CUOIKY_NHOM4_IM81
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FruitsStoreEntities2 : DbContext
    {
        public FruitsStoreEntities2()
            : base("name=FruitsStoreEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TimeSheet> TimeSheets { get; set; }
    
        public virtual ObjectResult<Nullable<int>> sp_KiemTraSPDonHang(Nullable<int> maDH, Nullable<int> maSP)
        {
            var maDHParameter = maDH.HasValue ?
                new ObjectParameter("MaDH", maDH) :
                new ObjectParameter("MaDH", typeof(int));
    
            var maSPParameter = maSP.HasValue ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_KiemTraSPDonHang", maDHParameter, maSPParameter);
        }
    
        public virtual ObjectResult<Nullable<bool>> sp_DangNhap(string userID, Nullable<int> password)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(string));
    
            var passwordParameter = password.HasValue ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("sp_DangNhap", userIDParameter, passwordParameter);
        }
    }
}
