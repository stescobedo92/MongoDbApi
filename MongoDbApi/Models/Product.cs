using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApi.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Category { get; set; }
    }
}
