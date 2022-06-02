using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HamzaTestAPP.Data;


namespace HamzaTestAPP.IRepository
{
    public interface IHouseRepository
    {
        Houses Save(Houses house);
        Houses GetHouse(string houseId);

        List<Houses> GetsHouses();
        Houses Update(Houses house);
        string Delete(string houseId);
    }
}
