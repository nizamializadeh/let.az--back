namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        public int id { get; set; }

        [StringLength(500)]
        public string AboutText { get; set; }

        [StringLength(500)]
        public string RulesText { get; set; }
    }
}
