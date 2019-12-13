using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sacrament.Models
{
    public class Meeting
    {

        public int ID { get; set; }

        [Required]
        [Display(Name = "Presiding")]
        [StringLength(50)]
        public string Preside { get; set; }

        [Required]
        [Display(Name = "Conducting")]
        [StringLength(50)]
        public string Conduct { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        [Display(Name = "Invocation")]
        [StringLength(50)]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Benediction")]
        [StringLength(50)]
        public string ClosingPrayer { get; set; }

        public Hymn hymn { get; set; }

        public ICollection<Hymn> Hymns { get; set; }

        public Speaker speaker { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
