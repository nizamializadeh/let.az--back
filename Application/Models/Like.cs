namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Like")]
    public partial class Like
    {
        public int id { get; set; }

        public int? User_id { get; set; }

        public int? Product_id { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
