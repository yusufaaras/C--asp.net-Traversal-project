using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegistorViewModel
	{
		[Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
		public string SurName { get; set; }

		[Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi Giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi Giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi tekrar Giriniz")]
		[Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
		public string ConifrmPassword { get; set; }


	}
}
