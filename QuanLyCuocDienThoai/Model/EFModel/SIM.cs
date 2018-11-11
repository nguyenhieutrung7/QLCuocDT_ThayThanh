namespace Model.EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIM")]
    public partial class SIM
    {
        [Key]
        public int MaSIM { get; set; }

        [StringLength(20)]
        public string TenSim { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        public bool? Flag { get; set; }
    }
}
