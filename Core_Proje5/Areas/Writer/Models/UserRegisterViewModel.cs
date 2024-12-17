using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje5.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Lütfen Soyadınızı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        [Compare("Password",ErrorMessage = "Şifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Resim değeri Giriniz")]
        public string ImageUrl { get; set; }
    }
}
