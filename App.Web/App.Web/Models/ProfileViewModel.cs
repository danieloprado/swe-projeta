using System.ComponentModel.DataAnnotations;

namespace App.Web.Models
{
    public class ProfileViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}