using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklama kısmı boş!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakter giriniz!");
            RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Lütfen açıklamayı kısaltın...!");
        }
    }
}
