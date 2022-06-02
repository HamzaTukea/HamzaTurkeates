using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamzaTestAPP.Data
{
    [BsonIgnoreExtraElements]
    public class Houses
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        [BsonIgnoreIfDefault]
        public string HouseId { get; set; } = ObjectId.GenerateNewId().ToString();

        public string TypeOfOffer { get; set; } = "";

        public string Adress { get; set; } = "";
        public string Image { get; set; } = "";

    }
}
