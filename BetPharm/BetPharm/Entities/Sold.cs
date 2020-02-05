using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPharm.Entities
{
    public class Sold
    {
        public ObjectId Id { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfSale { get; set; }
        public MongoDBRef Worker { get; set; }
        public MongoDBRef Medicament { get; set; }
    }
}
