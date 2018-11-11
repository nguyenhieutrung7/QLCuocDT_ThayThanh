namespace Model.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonDangKy")]
    public partial class HoaDonDangKy
    {
        public int HoaDonDangKyID { get; set; }

        public int KhachHangID { get; set; }

        public int SIMID { get; set; }

        public DateTime NgayDK { get; set; }

        public int ChiPhiDK { get; set; }

        public bool TinhTrangThanhToan { get; set; }

        public bool Flag { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual SIM SIM { get; set; }
    }
}
