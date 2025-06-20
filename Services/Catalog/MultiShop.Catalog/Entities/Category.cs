﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // benzersiz olduğunu belirtmek için kulanılıyor
        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
