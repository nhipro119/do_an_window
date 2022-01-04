namespace QuanLyCuaHangTapHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaPhanPhoi")]
    public partial class NhaPhanPhoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaPhanPhoi()
        {
            DonDatHangs = new HashSet<DonDatHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaNPP { get; set; }

        [StringLength(50)]
        public string TenNPP { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(25)]
        public string Email { get; set; }

        [StringLength(10)]
        public string MaLH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}
