using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPractice.Models
{
    public class FormResponse
    {
        [Key] //This will tell the program that the line below is the key
        [Required]
        public int FormId { get; set; } //Each table column needs a getter and setter
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Year.")]
        public uint Year { get; set; }
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Director.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Rating.")]
        public string Rating { get; set; }
        public string Edit { get; set; }

        public string Lent { get; set; }

        public string Notes { get; set; }
    }
}
