using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace GymManagementMVC.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name can't be empty")]
        public string TrainerName { get; set; }

        [Required(ErrorMessage = "Gender can't be empty")]
        public string Gender { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Age can't be empty")]
        public decimal Age { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public decimal Experience { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string Expertise { get; set; }
    }
}

