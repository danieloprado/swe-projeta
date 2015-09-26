using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSchool.Domain.Entities
{
    public class Lecture
    {
        private Lecture()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Description { get; set; }

        public static Lecture Create(string description)
        {
            return new Lecture()
            {
                Description = description
            };
        }
    }
}
