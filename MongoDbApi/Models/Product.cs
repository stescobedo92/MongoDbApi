﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbApi.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Category { get; set; }
    }
}
