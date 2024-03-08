﻿using DTOLayer.DTOS.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator:AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlık Giriniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Duyuru içeriğini Giriniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Giriniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Giriniz");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen En Az 20 Karakter Giriniz");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen En Fazla 500 Karakter Giriniz");
        }
    }
}
