namespace BDKINOTEATR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avtorizaciya")]
    public partial class Avtorizaciya
    {
        public int ID { get; set; }

        [StringLength(60)]
        public string Login { get; set; }

        [StringLength(60)]
        public string Password { get; set; }

        public int? IDRols { get; set; }

        public virtual Roli Roli { get; set; }
    }
}
