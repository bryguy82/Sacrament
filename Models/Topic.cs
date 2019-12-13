using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sacrament.Models
{
    public class Topic
    {
        public int TopicId { get; set; }

        [Required]
        [Display(Name = "Subject")]
        [StringLength(50)]
        public string Subject { get; set; }
    }
}
