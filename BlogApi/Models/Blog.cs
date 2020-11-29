using System.ComponentModel.DataAnnotations;


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
        public User userId {get;set;}
    }
}