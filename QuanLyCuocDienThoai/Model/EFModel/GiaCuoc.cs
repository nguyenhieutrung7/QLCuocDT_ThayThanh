namespace Model.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaCuoc")]
    public partial class GiaCuoc
    {
        public int GiaCuocID { get; set; }

        [StringLength(20)]
        public string GioBD { get; set; }

        [StringLength(20)]
        public string GioKT { get; set; }

        public int? GiaTien { get; set; }

        public bool? Flag { get; set; }
    }
}
