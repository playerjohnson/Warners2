using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warners.Data.Models;

namespace Warners.Models
{
    public class ResultsViewModel
    {
        public IEnumerable<GradedItemModel> GradedFoodItems { get; set; }
        
    }
}