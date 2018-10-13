namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhotoGallerey")]
    public partial class PhotoGallerey
    {
        public int id { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        [StringLength(1)]
        public string Role { get; set; }

        public int? Shop_id { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
