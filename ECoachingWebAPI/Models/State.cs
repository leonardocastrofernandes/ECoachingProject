using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECoachingWebAPI.Models
{
    [Table("State")]
    public class State
    {      
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int StateId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string StateName { get; set; }

        //Foreign key for Country
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}