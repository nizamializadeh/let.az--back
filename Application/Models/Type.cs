namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Type")]
    public partial class Type
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Nama { get; set; }

        [StringLength(10)]
        public string Count { get; set; }

        public int? Product_id { get; set; }

        public virtual Product Product { get; set; }
    }
}
