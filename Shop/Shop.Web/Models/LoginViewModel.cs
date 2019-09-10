using System.ComponentModel.DataAnnotations;

namespace Shop.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
