using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sacrament.Models
{
    public class Speaker
    {

        public int SpeakerId { get; set; }

        [StringLength(50)]
        public string FirstName_1 { get; set; }

        [StringLength(50)]
        public string LastName_1 { get; set; }

        [StringLength(50)]
        public string FirstName_2 { get; set; }

        [StringLength(50)]
        public string LastName_2 { get; set; }

        [StringLength(50)]
        public string FirstName_3 { get; set; }

        [StringLength(50)]
        public string LastName_3 { get; set; }

        [StringLength(50)]
        public string FirstName_4 { get; set; }

        [StringLength(50)]
        public string LastName_4 { get; set; }

        public Topic Topic { get; set; }

        public ICollection<Topic> Topics { get; set; }
    }
}
