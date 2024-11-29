using System.ComponentModel.DataAnnotations;

namespace LoginUsers.Models
{
    public class Persons
    {
        [Key]
        [Required]
        public int Id { get; set; }  

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}