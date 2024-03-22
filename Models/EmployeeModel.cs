using System.ComponentModel.DataAnnotations;

namespace Employee1.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        public int Salary { get; set; }

        public string Gender { get; set; }

        public string ImageUrl { get; set; }
    }
}
