namespace QuanLyCuaHangTapHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhapHang")]
    public partial class PhieuNhapHang
    {
        [Key]
        [StringLength(10)]
        public string MaPN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        public long? TongTien { get; set; }
        [StringLength(10)]
        public string MaNPP { get; set; }
        public string MaDDH { get; set; }

        public virtual DonDatHang DonDatHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
