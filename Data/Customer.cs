using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamzaTestAPP.Data
{
    [BsonIgnoreExtraElements]
    public class Customer
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        [BsonIgnoreIfDefault]
        public string CustomerId { get; set; } = ObjectId.GenerateNewId().ToString();

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public int Phone { get; set; }  = 0; 
        public int Phone1 { get; set; } = 0;

        public string adress { get; set; } = "";

        public string street { get; set; } = "";
        public int PostalCode { get; set; } = 0;

        public int HouseNumber { get; set; } = 0;
    }
}
