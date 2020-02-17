using FluentValidation;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Validations.FluentValidation
{
    public class UserValidator:AbstractValidator<Uye>
    {        
        public UserValidator()
        {
            RuleFor(x => x.uye_ad).NotEmpty().WithMessage("Üye adı boş geçilemez.").Length(2, 15).WithMessage("Üye adı 2-15 karakter arasında olmalıdır.");
            RuleFor(x => x.uye_soyad).NotEmpty().WithMessage("Üye soyadı boş geçilemez.").Length(3, 20).WithMessage("Üye soyadı 3 - 20 karakter arasında olmalıdır.");            
        }

        
    }
}
