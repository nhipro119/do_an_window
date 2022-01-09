namespace QuanLyCuaHangTapHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPNH")]
    public partial class CTPNH
    {
        [Key]
        [Column(Order = 0 )]
        [StringLength(10)]
        public string MaPN { get; set; }
        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public Int64 DonGia { get; set; }
        public string DVT { get; set; }
        public virtual HangHoa HangHoa { get; set; }
        public virtual PhieuNhapHang PhieuNhapHang { get; set; }
        
    }
}
