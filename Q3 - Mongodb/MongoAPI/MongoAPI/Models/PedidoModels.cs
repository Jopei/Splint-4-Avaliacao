using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongoAPI.Models
{
    public class PedidoModels
    {
        [BsonId]
        public string orderId { get; set; }
        public DateTime eventDate { get; set; }
        public string description { get; set; }
        public string api { get; set; }
        public IDictionary<string, string> content { get; set; }
    }
}
