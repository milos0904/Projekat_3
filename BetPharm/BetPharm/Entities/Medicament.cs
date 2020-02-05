using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPharm
{
    public class Medicament
    {
        public ObjectId Id { get; set; }
        public String Name { get; set; }
        public String Producer { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public String PharmaceuticalForm { get; set; }
        public String Approved { get; set; }
        public float DDD { get; set; } //10mg, 20mg
        public float Price { get; set; }
        public int Quantity { get; set; }
        public MongoDBRef Worker { get; set; }
    }
}
