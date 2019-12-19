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
        public Meeting() { }

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

        /*MEETING HYMNS*/
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

        /*MEETING SPEAKERS*/
        [Display(Name = "1st Speaker: First Name")]
        [StringLength(50)]
        public string FirstName_1 { get; set; }

        [Display(Name = "1st Speaker: Last Name")]
        [StringLength(50)]
        public string LastName_1 { get; set; }

        [Display(Name = "1st Speaker: Topic")]
        [StringLength(50)]
        public string Topic_1 { get; set; }

        [Display(Name = "2nd Speaker: First Name")]
        [StringLength(50)]
        public string FirstName_2 { get; set; }

        [Display(Name = "2nd Speaker: Last Name")]
        [StringLength(50)]
        public string LastName_2 { get; set; }

        [Display(Name = "2nd Speaker: Topic")]
        [StringLength(50)]
        public string Topic_2 { get; set; }

        [Display(Name = "3rd Speaker: First Name")]
        [StringLength(50)]
        public string FirstName_3 { get; set; }

        [Display(Name = "3rd Speaker: Last Name")]
        [StringLength(50)]
        public string LastName_3 { get; set; }

        [Display(Name = "3rd Speaker: Topic")]
        [StringLength(50)]
        public string Topic_3 { get; set; }

        [Display(Name = "4th Speaker: First Name")]
        [StringLength(50)]
        public string FirstName_4 { get; set; }

        [Display(Name = "4th Speaker: Last Name")]
        [StringLength(50)]
        public string LastName_4 { get; set; }

        [Display(Name = "4th Speaker: Topic")]
        [StringLength(50)]
        public string Topic_4 { get; set; }

    }
}
