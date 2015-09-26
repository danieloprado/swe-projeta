using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSchool.Domain.Entities
{
    public class Topic
    {
        private Topic()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; private set; }

        public static Topic Create()
        {
            return new Topic();
        }
    }
}
