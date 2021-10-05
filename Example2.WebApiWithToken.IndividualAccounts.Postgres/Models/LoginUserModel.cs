using System.ComponentModel.DataAnnotations;

namespace Example2.WebApiWithToken.IndividualAccounts.Postgres.Models
{
    public class LoginUserModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}