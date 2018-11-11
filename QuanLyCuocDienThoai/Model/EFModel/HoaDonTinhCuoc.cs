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
        [Key]
        public int MaHD { get; set; }

        public int? MaKH { get; set; }

        public DateTime? NgayBD { get; set; }

        public DateTime? NgayKT { get; set; }

        public int? CuocThueBao { get; set; }

        public int? ThanhTien { get; set; }

        public int? TongTien { get; set; }

        public bool? Flag { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
