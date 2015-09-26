using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using PlanSchool.Domain.Entities;
using PlanSchool.Infra;

namespace PlanSchool.Web.Controllers
{
    public class TopicController : ApiController
    {
        private readonly TopicRepository _repository;

        public TopicController()
        {
            _repository = new TopicRepository();
        }

        public async Task<List<Topic>> List()
        {
            return await _repository.List();
        }
    }
}