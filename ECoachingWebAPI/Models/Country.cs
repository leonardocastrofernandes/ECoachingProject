using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECoachingWebAPI.Models
{
    [Table("Country")]
    public class Country
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string CountryName { get; set; }

        public ICollection<State> States { get; set; }        
    }    
}