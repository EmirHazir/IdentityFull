using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcPot.Models
{
    public class Feedback
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? Answer { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        [StringLength(50)]
        [Required]
        public string FullName { get; set; }

        [StringLength(120)]
        [Required]
        public string Email { get; set; }

    }
}