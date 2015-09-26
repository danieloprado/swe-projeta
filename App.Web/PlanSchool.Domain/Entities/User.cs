using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanSchool.Domain.Entities
{
    public class User
    {
        private User()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; private set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public static User Create(string name, string role)
        {
            return new User()
            {
                Name = name,
                Role = role
            };
        }
    }
}
