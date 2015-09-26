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
    public class TopicRepository : Repository
    {
        private readonly IMongoCollection<Topic> _collection;

        public TopicRepository()
        {
            _collection = Db.GetCollection<Topic>("topic");
        }

        public async Task<Topic> Find(string id)
        {

            var filter = new BsonDocumentFilterDefinition<Topic>(new BsonDocument
            {
                { "_id", id }
            });
            var result = await _collection.FindAsync(filter);

            return result.ToListAsync().Result.FirstOrDefault();
        }

        public async Task<List<Topic>> List()
        {
            return await _collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<Topic> Insert(Topic topic)
        {
            await _collection.InsertOneAsync(topic);
            return topic;
        }
    }
}
