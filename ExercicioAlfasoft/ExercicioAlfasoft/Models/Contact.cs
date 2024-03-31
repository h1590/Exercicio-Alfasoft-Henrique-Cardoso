using System.ComponentModel.DataAnnotations;

namespace ExercicioAlfasoft.Models
{
    public class Contact
    {
        public bool isDeleted { get; set; }


        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string name { get; set; }

        [Required]
        [MinLength(9), MaxLength(9), DataType(DataType.PhoneNumber)]
        public string phoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public Contact()
        {

        }


    }
}
