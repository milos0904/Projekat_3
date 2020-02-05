using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPharm.Entities
{
    public class Admin
    {
        public ObjectId Id { get; set; }
        public String Type { get; set; }
        public String UserName { get; set; }
        public String AdminCode { get; set; }
    }
}
