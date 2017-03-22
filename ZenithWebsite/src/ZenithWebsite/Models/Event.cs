using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ZenithWebsite.Models
{
    public class Event
    {
        [Display(Name = "Event ID")]
        public int EventId { get; set; }
        // [DisplayFormat(DataFormatString = "{0:h:mm tt}")]

        [Required(ErrorMessage = "Events must have a starting time.")]
        [Display(Name = "Starting Time")]
        public DateTime EventFrom { get; set; }

        [Required(ErrorMessage = "Events must have an ending time.")]
        [Display(Name = "Ending time")]
        public DateTime EventTo { get; set; }

        [Display(Name = "Creator")]
        public string EnteredBy { get; set; }

        [Display(Name = "Activity ID")]
        public int ActivityId { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Active?")]
        public bool IsActive { get; set; }

        public virtual Activity Activity { get; set; }
    }
}
