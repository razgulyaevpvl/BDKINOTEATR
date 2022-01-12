namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seans
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seans()
        {
            Bilet = new HashSet<Bilet>();
        }

        [Key]
        public int IDSeansa { get; set; }

        public int? IDFilma { get; set; }

        public int? IDZala { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataPokaza { get; set; }

        public TimeSpan? Vremya { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }

        public virtual Film Film { get; set; }

        public virtual Zal Zal { get; set; }
    }
}
