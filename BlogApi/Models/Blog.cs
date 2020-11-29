using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApi.Models
{
    public class Blog 
    {
         [Key]
        public int Id{get;set;}
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description {get;set;}
        [Required]
        public int userId {get;set;}
        [ForeignKey("userId")]
        public User User{get;set;}
        
    }
}