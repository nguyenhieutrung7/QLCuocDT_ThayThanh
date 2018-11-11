namespace Model.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonTinhCuoc")]
    public partial class HoaDonTinhCuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonTinhCuoc()
        {
            ChitietHDTCs = new HashSet<ChitietHDTC>();
        }

        public int HoaDonTinhCuocID { get; set; }

        public int KhachHangID { get; set; }

        public DateTime NgayBD { get; set; }

        public DateTime NgayKT { get; set; }

        public int CuocThueBao { get; set; }

        public int ThanhTien { get; set; }

        public int TongTien { get; set; }

        public bool Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChitietHDTC> ChitietHDTCs { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
