using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sacrament.Models
{
    public class Hymn
    {

        public int HymnId { get; set; }

        [Required]
        [Display(Name = "Page")]
        public int Hymn_1Num { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        [StringLength(50)]
        public string Hymn_1 { get; set; }

        [Required]
        [Display(Name = "Page")]
        public int Hymn_2Num { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        [StringLength(50)]
        public string Hymn_2 { get; set; }

        // Not required
        [Display(Name = "Page")]
        public int Hymn_3Num { get; set; }

        // Not required
        [Display(Name = "Special Musical Number")]
        [StringLength(50)]
        public string Hymn_3 { get; set; }

        [Required]
        [Display(Name = "Page")]
        public int Hymn_4Num { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        [StringLength(50)]
        public string Hymn_4 { get; set; }
    }
}
