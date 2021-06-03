using System.ComponentModel.DataAnnotations;

namespace MotoShop.UI.ViewModels.Admin
{
    public class CreateUserViewModel
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
