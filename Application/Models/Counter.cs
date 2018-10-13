namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Counter")]
    public partial class Counter
    {
        public int id { get; set; }

        public int? Month { get; set; }

        public int? Day { get; set; }
    }
}
