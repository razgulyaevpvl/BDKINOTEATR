namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bilet")]
    public partial class Bilet
    {
        [Key]
        public int IDBileta { get; set; }

        public int? IDSeansa { get; set; }

        public int? IDMesta { get; set; }

        public int? IDKategorii { get; set; }

        [Column(TypeName = "money")]
        public decimal? CenaBileta { get; set; }

        public virtual KategoriyaBileta KategoriyaBileta { get; set; }

        public virtual Mesto Mesto { get; set; }

        public virtual Seans Seans { get; set; }
    }
}
