namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Chek_Bileta
    {
        [Column(TypeName = "datetime2")]
        public DateTime? Data_Vremya { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cena { get; set; }

        public string FIO { get; set; }

        [StringLength(60)]
        public string Nazvanie { get; set; }

        [Column(TypeName = "money")]
        public decimal? Zarplata { get; set; }

        [StringLength(60)]
        public string Telephon { get; set; }

        [StringLength(60)]
        public string EMail { get; set; }

        [Column(TypeName = "money")]
        public decimal? CenaBileta { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mesto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ryad { get; set; }

        [StringLength(60)]
        public string NazvanieKategorii { get; set; }
    }
}
