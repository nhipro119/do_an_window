namespace QuanLyCuaHangTapHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaHang { get; set; }

        [StringLength(50)]
        public string TenHang { get; set; }

        public int? SLTon { get; set; }

        [StringLength(10)]
        public string DVT { get; set; }

        public long? DonGia { get; set; }

        [StringLength(10)]
        public string MaLH { get; set; }
        public Boolean isDelete { get; set; }
        public Int64 GiaGoc { get; set; }
        public int TrongLuong { get; set; }
        public string MaNPP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual LoaiHang LoaiHang { get; set; }
    }
}
