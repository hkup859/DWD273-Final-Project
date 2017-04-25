using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DWD273_Final_Project.Models
{
    public class Ticket
    {

        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Message")]
        public string message { get; set; }
        [Display(Name = "Topic")]
        public string topic { get; set; }
        public DateTime submitTime { get; set; }
        public Boolean resolved { get; set; }
    }
}