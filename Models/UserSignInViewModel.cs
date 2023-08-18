using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;



namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
        public string password { get; set; }
    }
}
