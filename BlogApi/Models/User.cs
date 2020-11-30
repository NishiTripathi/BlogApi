using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        public string fname{get;set;}
        [Required]
        public string lname {get;set;}
        [Required]
        public string email {get;set;}
        [Required]
        public string password{get;set;}
        public virtual Blog Blog{get;set;}
    }
    
}