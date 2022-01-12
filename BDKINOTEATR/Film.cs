namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Film")]
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            Seans = new HashSet<Seans>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDFilma { get; set; }

        [StringLength(60)]
        public string NazvanieFilma { get; set; }

        [StringLength(60)]
        public string VozrastnoyReyting { get; set; }

        public int Dlitelnost { get; set; }

        public int? IDStrana { get; set; }

        public int? IDZhanra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NachaloProkata { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KonecProkata { get; set; }

        public virtual Strana Strana { get; set; }

        public virtual Zhanr Zhanr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seans> Seans { get; set; }
    }
}
