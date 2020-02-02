using MongoDB.Bson;
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
        public static MongoDatabase  GetDataBase()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = MongoServer.Create(connectionString);
            return client.GetDatabase("apoteka");

            
        }
    }
}
