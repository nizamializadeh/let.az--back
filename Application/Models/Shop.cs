namespace Application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shop")]
    public partial class Shop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop()
        {
            PhotoGallereys = new HashSet<PhotoGallerey>();
            Products = new HashSet<Product>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Queue { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(150)]
        public string Adress { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [StringLength(100)]
        public string Coverphoto { get; set; }

        [StringLength(1)]
        public string Role { get; set; }

        [StringLength(1)]
        public string Partner { get; set; }

        [StringLength(1)]
        public string cat_Role { get; set; }

        [StringLength(50)]
        public string Opentime { get; set; }

        [StringLength(50)]
        public string Closetime { get; set; }

        [Column(TypeName = "text")]
        public string About { get; set; }

        [StringLength(150)]
        public string Locaton { get; set; }

        public int? Catagory_id { get; set; }

        public DateTime? Time { get; set; }

        public int? Foto_limit { get; set; }

        public int? Seen_shop { get; set; }

        public int? Product_number { get; set; }

        public virtual Catagory Catagory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhotoGallerey> PhotoGallereys { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
