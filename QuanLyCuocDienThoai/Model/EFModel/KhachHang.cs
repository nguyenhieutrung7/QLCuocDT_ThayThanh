namespace Model.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            HoaDonDangKies = new HashSet<HoaDonDangKy>();
            HoaDonTinhCuocs = new HashSet<HoaDonTinhCuoc>();
        }

        public int KhachHangID { get; set; }

        [Required]
        [StringLength(20)]
        public string TenKH { get; set; }

        [Required]
        [StringLength(20)]
        public string CMND { get; set; }

        [Required]
        [StringLength(20)]
        public string NgheNghiep { get; set; }

        [Required]
        [StringLength(20)]
        public string ChucVu { get; set; }

        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }

        public bool Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }
    }
}
