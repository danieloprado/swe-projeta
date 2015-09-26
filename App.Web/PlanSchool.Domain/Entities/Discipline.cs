using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSchool.Domain.Entities
{
    public class Discipline
    {
        private Discipline()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public static Discipline Create(string name)
        {
            return new Discipline()
            {
                Name = name
            };
        }
    }
}
