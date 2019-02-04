using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warners.Data.Models;

namespace Warners.Models
{
    public class GradeViewModel
    {
        [Display(Name = "FoodItem")]
        [Required(ErrorMessage = "{0} is required.")]
        public int SelectedFoodId { get; set; }
        public IEnumerable<SelectListItem> FoodItems { get; set; }
        public Grade Grade { get; set; }
    }
}