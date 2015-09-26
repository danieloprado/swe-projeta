using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Gorilla.Utilities;
using Gorilla.Utilities.Bags;
using PlanSchool.Domain.Entities;
using PlanSchool.Infra;
using PlanSchool.Web.Models;

namespace PlanSchool.Web.Controllers
{
    public class DisciplineController : ApiController
    {
        private readonly DisciplineRepository _repository;

        public DisciplineController()
        {
            _repository = new DisciplineRepository();
        }

        public async Task<TypedMethodFeedback<Discipline>> Create(DisciplineViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return TypedMethodFeedback<Discipline>.Fail(ModelState.GetErrors());
            }

            var discipline = Discipline.Create(model.Name);
            await _repository.Insert(discipline);

            return TypedMethodFeedback<Discipline>.Succeed(discipline);
        }
    }
}