using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warners.Data.Models
{
    public class Grade
    {
        [Range(1, 5, ErrorMessage = "Grade must e between 1 - 5")]
        public int Presentation { get; set; }
        [Range(1, 5, ErrorMessage = "Grade must e between 1 - 5")]
        public int Aroma { get; set; }
        [Range(1, 5, ErrorMessage = "Grade must e between 1 - 5")]
        public int Texture { get; set; }
        [Range(1, 5, ErrorMessage = "Grade must e between 1 - 5")]
        public int Flavour { get; set; }
    }
}
