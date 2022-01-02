using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCuaHangTapHoa
{
    public partial class QLCH : DbContext
    {
        public QLCH()
            : base("name=QLCH")
        {
        }

        public virtual DbSet<DonDatHang> DonDatHangs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaPhanPhoi> NhaPhanPhois { get; set; }
        public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.MaDDH)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.MaNPP)
                .IsUnicode(false);

            modelBuilder.Entity<DonDatHang>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHang)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DVT)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaLH)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HangHoa)
                .HasForeignKey(e => e.MaHH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.SDTKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDTKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiHang>()
                .Property(e => e.MaLH)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhaPhanPhoi>()
                .Property(e => e.MaNPP)
                .IsUnicode(false);

            modelBuilder.Entity<NhaPhanPhoi>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhaPhanPhoi>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaPN)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaDDH)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhapHang>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaHH)
                .IsUnicode(false);
        }
    }
}
