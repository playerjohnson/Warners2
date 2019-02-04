using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warners.Data.Models
{
    public class FoodItem
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public string Ingredients { get; set; }

        [StringLength(255)]
        public string Allergy { get; set; }
    }
}
