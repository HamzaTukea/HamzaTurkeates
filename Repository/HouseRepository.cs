using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HamzaTestAPP.Data;
using HamzaTestAPP.IRepository;
using MongoDB.Driver;

namespace HamzaTestAPP.Repository
{
    public class HouseRepository : IHouseRepository
    {
        private MongoClient mongoclient = null;

        private IMongoDatabase database = null;

        private IMongoCollection<Houses> house = null;

        public HouseRepository()
        {
            mongoclient = new MongoClient("mongodb://127.0.0.1:27017/");
            database = mongoclient.GetDatabase("HamzaDB");
            house = database.GetCollection<Houses>("Housess");

        }

        public string Delete(string houseId)
        {
            house.DeleteOne(x => x.HouseId == houseId);
            return "Deleted";
        }

        public Houses GetHouse(string houseId)
        {
            return house.Find(x => x.HouseId == houseId).FirstOrDefault();
        }

        public List<Houses> GetsHouses()
        {
            return house.Find(FilterDefinition<Houses>.Empty).ToList();
        }

        public Houses Save(Houses houses)
        {
            var obj = house.Find(x => x.HouseId == houses.HouseId).FirstOrDefault();
            if(obj == null)
            {
                house.InsertOne(houses);
            }
            else
            {
                house.ReplaceOne(x => x.HouseId == houses.HouseId ,houses);
            }

            return houses;
        }

        public Houses Update(Houses houses)
        {
            var obj = house.Find(x => x.HouseId == houses.HouseId).FirstOrDefault();
            if (obj != null)
            {
                house.ReplaceOne(x => x.HouseId == houses.HouseId, houses);
            }
            
            return houses;
        }
    }
}
