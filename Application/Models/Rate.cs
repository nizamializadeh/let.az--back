namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rate")]
    public partial class Rate
    {
        public int id { get; set; }

        public int? Product_id { get; set; }

        public int? User_id { get; set; }

        [StringLength(10)]
        public string cost { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
