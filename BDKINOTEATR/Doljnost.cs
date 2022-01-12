namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doljnost")]
    public partial class Doljnost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doljnost()
        {
            Sotrydnik = new HashSet<Sotrydnik>();
        }

        [Key]
        public int IDDoljnost { get; set; }

        [StringLength(60)]
        public string Nazvanie { get; set; }

        [Column(TypeName = "money")]
        public decimal? Zarplata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrydnik> Sotrydnik { get; set; }
    }
}
