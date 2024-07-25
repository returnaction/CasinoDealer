using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace CasinoDealer.Models.Models.QuestionModels
{
    public class UserAnswer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string  UserId { get; set; } = null!;

        public IdentityUser User { get; set; } = null!;

        [Required]
        public int QuestionId { get; set; }

        public Question Question { get; set; } = null!;

        [Required]
        public string Answer { get; set; } = null!;

        [Required]
        public bool IsCorrect { get; set; } 
    }
}
