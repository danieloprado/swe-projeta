using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace PlanSchool.Infra
{
    public class Repository
    {
        protected readonly IMongoDatabase Db;

        public Repository()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            Db = client.GetDatabase("planSchool");
        }
    }
}
