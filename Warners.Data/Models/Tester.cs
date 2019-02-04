using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warners.Data
{
    [Table("Testers")]

    public class Tester
    {
        public int ID { get; set; }

        public string UserId { get; set; }
        /*
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public virtual IdentityUser ApplicationUser { get; set; }*/
    }
}
