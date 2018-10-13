namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class We_contact
    {
        public int id { get; set; }

        [StringLength(500)]
        public string Text { get; set; }
    }
}
