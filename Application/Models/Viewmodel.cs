using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Viewmodel
    {
        public Product product { get; set; }
        public User user { get; set; }
        public Shop shop { get; set; }
        public Catagory catagory { get; set; }
        public IEnumerable<Product> ie_product { get; set; }
        public IEnumerable<Rate> ie_Rate { get; set; }
        public IEnumerable<Like> ie_like { get; set; }
        public IEnumerable<PhotoGallerey> ie_photo { get; set; }
        public IEnumerable<Shop> ie_shop { get; set; }
    }
}