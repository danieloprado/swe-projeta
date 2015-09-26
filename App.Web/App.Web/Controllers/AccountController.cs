using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Gorilla.Utilities.Bags;
using PlanSchool.Web.Models;
using Gorilla.Utilities;
using PlanSchool.Domain.Entities;

namespace PlanSchool.Web.Controllers
{
    public class AccountController : ApiController
    {
        public TypedMethodFeedback<User> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return TypedMethodFeedback<User>.Fail(ModelState.GetErrors());
            }

            if (model.Login == "professor" && model.Password == "1234")
            {
                return TypedMethodFeedback<User>.Succeed(Domain.Entities.User.Create("Joaquim", "professor"));
            }

            return TypedMethodFeedback<User>.Fail("Dados inválidos");
        }

    }
}