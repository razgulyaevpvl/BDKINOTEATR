namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chek")]
    public partial class Chek
    {
        [Key]
        public int IDCheka { get; set; }

        public int? IDSotrydnika { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Data_Vremya { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cena { get; set; }

        public virtual Sotrydnik Sotrydnik { get; set; }
    }
}
