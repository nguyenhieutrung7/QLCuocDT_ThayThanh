namespace Model.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChitietHDTC")]
    public partial class ChitietHDTC
    {
        public int ChitietHDTCID { get; set; }

        public int HoaDonTinhCuocID { get; set; }

        public int SoPhutSD { get; set; }

        public int GiaCuoc { get; set; }

        public int ThanhTien { get; set; }

        public bool Flag { get; set; }

        public virtual HoaDonTinhCuoc HoaDonTinhCuoc { get; set; }
    }
}
