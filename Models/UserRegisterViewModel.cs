using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
        [Required(ErrorMessage ="Lütfen isim giriniz.")]
		public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }

        [Compare("Password" , ErrorMessage ="Şifreler uyumlu değil.")]
        public string ConfirmPassword { get; set; }


    }
}
