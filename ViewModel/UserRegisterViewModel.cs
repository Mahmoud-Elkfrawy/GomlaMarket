using GomlaMarket.Filter;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;


namespace GomlaMarket.ViewModel
{
    public class UserRegisterViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]

        public string Address { get; set; }

    }
}
