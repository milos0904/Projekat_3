using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPharm.Entities
{
    public class Worker
    {
        public ObjectId Id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String Surname { get; set; }
        public String UserName { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime DateEmployment { get; set; }
        public DateTime DateRelease { get; set; }
        public String Sex { get; set; }
        public String Address { get; set; }
        public double Pay { get; set; }
        public String Position { get; set; }
        public String WorkerCode { get; set; }
        public DateTime? StoppedWorking { get; set; }
        public bool Employed { get; set; }
    }
}
