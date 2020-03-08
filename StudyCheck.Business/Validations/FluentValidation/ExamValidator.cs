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
    public class ExamValidator:AbstractValidator<Sinav>
    {              
        public ExamValidator()
        {
            RuleFor(x => x.sinav_ad).NotEmpty().WithMessage("Sınav adı boş geçilemez.")
                .Length(2,15).WithMessage("Sınav adı 2-15 karakter arasında olmalıdır.")
                .Matches(Utility.regexTR).WithMessage("Sınav adı özel karakter içeremez.");
            RuleFor(x => x.sinav_tarih).NotEmpty().WithMessage("Sınav tarihi boş geçilemez.");
            RuleFor(x => x.ekleyen_id).NotEmpty().WithMessage("Ekleyen id boş geçilemez.");     
                

        }        
    }
}
