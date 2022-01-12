namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sotrydnik")]
    public partial class Sotrydnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrydnik()
        {
            Chek = new HashSet<Chek>();
        }

        [Key]
        public int IDSotrydnika { get; set; }

        public string FIO { get; set; }

        public int? IDDoljnost { get; set; }

        [StringLength(60)]
        public string Telephon { get; set; }

        [StringLength(60)]
        public string EMail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chek> Chek { get; set; }

        public virtual Doljnost Doljnost { get; set; }
    }
}
