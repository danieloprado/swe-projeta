using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using PlanSchool.Domain.Entities;

namespace PlanSchool.Infra
{
    public class DisciplineRepository : Repository
    {
        private readonly IMongoCollection<Discipline> _collection;

        public DisciplineRepository()
        {
            _collection = Db.GetCollection<Discipline>("discipline");
        }

        public async Task<Discipline> Find(string id)
        {

            var filter = new BsonDocumentFilterDefinition<Discipline>(new BsonDocument
            {
                { "_id", id }
            });
            var result = await _collection.FindAsync(filter);

            return result.ToListAsync().Result.FirstOrDefault();
        }

        public async Task<List<Discipline>> List()
        {
            return await _collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<Discipline> Insert(Discipline discipline)
        {
            await _collection.InsertOneAsync(discipline);
            return discipline;
        }
    }
}
