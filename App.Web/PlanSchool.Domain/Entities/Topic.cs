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
            Lectures = new List<Lecture>();
        }

        public string Id { get; set; }

        public string DisciplineId { get; set; }

        public string Description { get; set; }

        public DateTime StartdaDateTime { get; set; }

        public DateTime EnDateTime { get; set; }


        public List<Lecture> Lectures { get; set; }

        public static Topic Create(Discipline discipline, string description)
        {
            return new Topic()
            {
                DisciplineId = discipline.Id,
                Description = description
            };
        }
    }
}
