namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zal")]
    public partial class Zal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zal()
        {
            Seans = new HashSet<Seans>();
        }

        [Key]
        public int IDZala { get; set; }

        [StringLength(60)]
        public string Nazvanie { get; set; }

        public int KolichestvoMest { get; set; }

        public int KolichestvoRyadov { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seans> Seans { get; set; }
    }
}
