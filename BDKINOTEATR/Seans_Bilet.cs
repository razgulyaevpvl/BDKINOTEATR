namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seans_Bilet
    {
        [StringLength(60)]
        public string NazvanieFilma { get; set; }

        [StringLength(60)]
        public string VozrastnoyReyting { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dlitelnost { get; set; }

        [StringLength(60)]
        public string Strana { get; set; }

        [StringLength(60)]
        public string Zhanr { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NachaloProkata { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KonecProkata { get; set; }

        [StringLength(60)]
        public string Nazvanie { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KolichestvoMest { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KolichestvoRyadov { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataPokaza { get; set; }

        public TimeSpan? Vremya { get; set; }

        [Column(TypeName = "money")]
        public decimal? CenaBileta { get; set; }
    }
}
