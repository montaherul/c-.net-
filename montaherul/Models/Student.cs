using System.ComponentModel.DataAnnotations;

namespace montaherul.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }
    }

}
