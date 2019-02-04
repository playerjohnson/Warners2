using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warners.Data.Models
{
    public class Marks
    {
        public int ID { get; set; }

        [ForeignKey("Tester")]
        public int TesterId { get; set; }
        public virtual Tester Tester { get; set; }

        [ForeignKey("FoodItem")]
        public int FoodItemId { get; set; }
        public virtual FoodItem FoodItem { get; set; }
            
        public string Grade { get; set; }
    }
}
