namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IstoriyaSeansov")]
    public partial class IstoriyaSeansov
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSeansa { get; set; }

        [StringLength(60)]
        public string NazvanieFilma { get; set; }

        [StringLength(60)]
        public string VozrastnoyReyting { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dlitelnost { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NachaloProkata { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KonecProkata { get; set; }

        [StringLength(60)]
        public string NazvanieZala { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KolichestvoMest { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KolichetvoRyadov { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataPokaza { get; set; }

        [Key]
        [Column(Order = 4)]
        public TimeSpan VremyaPokaza { get; set; }
    }
}
