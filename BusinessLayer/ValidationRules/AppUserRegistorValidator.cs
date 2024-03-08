using DTOLayer.DTOS.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegistorValidator:AbstractValidator<AppUserRegistorDTO>
    {
        public AppUserRegistorValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(x=>x.SurName).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(x=>x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x=>x.ConifrmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez");

            RuleFor(x=>x.UserName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Giriniz");
            RuleFor(x=>x.UserName).MaximumLength(20).WithMessage("Lütfen En fazla 20 Karakter Giriniz");
            RuleFor(x=>x.Password).Equal(y=>y.ConifrmPassword).WithMessage("Şifreler Uyuşmuyor");

        }
    }
}
