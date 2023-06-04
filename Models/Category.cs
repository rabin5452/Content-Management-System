using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(25)]
        public string content { get; set; }
        [DisplayName("Content Number")]
        [Range(1,50,ErrorMessage="Please enter number between 1-50")]
        public int contentnumber { get; set; }
    }
}
