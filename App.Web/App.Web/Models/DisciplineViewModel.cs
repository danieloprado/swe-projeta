using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlanSchool.Web.Models
{
    public class DisciplineViewModel
    {
        //public string Id { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}