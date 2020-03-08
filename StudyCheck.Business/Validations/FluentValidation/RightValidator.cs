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
    public class RightValidator:AbstractValidator<Yetki>
    {        
        public RightValidator()
        {
            RuleFor(x => x.yetki_adi).NotEmpty().WithMessage("Yetki adı boş geçilemez.")
                .Length(2, 8).WithMessage("Yetki adı 2-8 karakter arasında olmalıdır.")
                .Matches(Utility.regexTR).WithMessage("Yetki adı özel karakter içeremez.");
            RuleFor(x => x.ekleyen_id).NotEmpty().WithMessage("Ekleyen id boş geçilemez.");            
        }
    }
}
