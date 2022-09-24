using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCvProject.Areas.Writer.Models
{
    public class UserRegisterVieewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş olamaz !")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre boş olamaz !")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar boş olamaz !")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor lütfen kontrol ediniz !")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Mail adresi boş olamaz !")]
        public string Mail { get; set; }
    }
}
