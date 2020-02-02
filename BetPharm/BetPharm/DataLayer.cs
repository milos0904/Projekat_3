using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPharm
{
    public class DataLayer
    {
        public static IMongoDatabase GetDataBase()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            return client.GetDatabase("apoteka");
        }
    }
}
