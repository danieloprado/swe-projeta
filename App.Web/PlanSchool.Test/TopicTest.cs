using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanSchool.Domain.Entities;
using PlanSchool.Infra;

namespace PlanSchool.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task Create()
        {
            var repository = new TopicRepository();
            await repository.Insert(Topic.Create());
        }

        [TestMethod]
        public async Task Find()
        {
            var repository = new TopicRepository();
            var result = await repository.Find("5a4e996e-15ad-48fb-8a66-be9f358c13d4");
        }

        [TestMethod]
        public async Task List()
        {
            var repository = new TopicRepository();
            var result = await repository.List();
        }


    }
}
