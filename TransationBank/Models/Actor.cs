using ETicketApp.Models;
using System.ComponentModel.DataAnnotations;

namespace TransationBank.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name ="Profile Picture URL")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationship

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
