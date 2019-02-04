using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warners.Data.Models;

namespace Warners.Models
{
    public class GradedItemModel
    {
        public FoodItem FoodItem { get; set; }
        public Grade Grade { get; set; }

        public GradedItemModel(FoodItem foodItem, Grade grade)
        {
            this.FoodItem = foodItem;
            this.Grade = grade;
        }
    }
}