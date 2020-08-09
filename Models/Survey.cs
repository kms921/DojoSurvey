using System; 
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models 

{

    public class Survey 
    {
        [Required (ErrorMessage="Name required")]
        [MinLength(2, ErrorMessage= "Must have a minimum length of 2 characters")]
        [Display(Name = "Name:")] 
        public string Name { get; set; }
        [Required (ErrorMessage="Location required")]
        [Display(Name = "Dojo Location:")] 
        public string Location { get; set; }
        [Required (ErrorMessage="Favorite language required")]
        [Display(Name = "Favorite Language")] 
        public string Language { get; set; }
        [MinLength(20, ErrorMessage= "Must have a minimum length of 20 characters")]
        [Display(Name = "Comments:")] 
        public string Comment { get; set; }

    
    }
}