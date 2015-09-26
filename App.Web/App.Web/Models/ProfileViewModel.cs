using System.ComponentModel.DataAnnotations;

namespace PlanSchool.Web.Models
{
    public class ProfileViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}