namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("Image")]
    public partial class Image
    {
        public int id { get; set; }

        public int? Product_id { get; set; }

        [Column("Image")]
        [StringLength(100)]
        public HttpPostedFileBase[] Image1 { get; set; }

        public virtual Product Product { get; set; }
    }
}
