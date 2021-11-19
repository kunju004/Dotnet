using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace GymManagementMVC.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name can't be empty!")]
        public string EquipmentName { get; set; }
        [Required(ErrorMessage = "Price can't be empty!")]
        public decimal Quantity { get; set; }
        [Required(ErrorMessage = "Field can't be empty!")]
        public string MuscleFocus { get; set; }
        [Required(ErrorMessage = "Weight can't be empty!")]
        public decimal Weight { get; set; }
    }
}
