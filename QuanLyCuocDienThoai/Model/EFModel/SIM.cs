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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIM()
        {
            HoaDonDangKies = new HashSet<HoaDonDangKy>();
        }

        public int SIMID { get; set; }

        [Required]
        [StringLength(20)]
        public string TenSim { get; set; }

        [Required]
        [StringLength(20)]
        public string SDT { get; set; }

        public bool Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKies { get; set; }
    }
}
