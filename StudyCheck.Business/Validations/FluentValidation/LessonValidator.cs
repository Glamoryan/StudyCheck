using FluentValidation;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StudyCheck.Utilities;

namespace StudyCheck.Business.Validations.FluentValidation
{
    public class LessonValidator:AbstractValidator<Ders>
    {       
        public LessonValidator()
        {
            RuleFor(x => x.sinav_id).NotEmpty().WithMessage("Sınav id boş geçilemez.");
            RuleFor(x => x.ders_ad).NotEmpty().WithMessage("Ders adı boş geçilemez.")
                .Length(2,15).WithMessage("Ders adı 2-15 karakter arasında olmalıdır.")
                .Matches(Utility.regexTR).WithMessage("Ders adı özel karakter içeremez.");
            RuleFor(x => x.ekleyen_id).NotEmpty().WithMessage("Ekleyen id boş geçilemez.");

        }
    }
}
