using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDealer.Models.Models.QuestionModels
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } = null!;

        [Required]
        public string CorrectAnswer { get; set; } = null!;



    }
}
