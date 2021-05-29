using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDbApi.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Category { get; set; }
    }
}
