using System.ComponentModel.DataAnnotations;

namespace TransationBank.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography ")]
        public string Bio { get; set; }


        //Relationship
        public List<Movie> Movies { get; set; }
       
    }
}
