using FluentValidation;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyCheck.Utilities;

namespace StudyCheck.Business.Validations.FluentValidation
{
    public class ThemeValidator:AbstractValidator<Tema>
    {
        public ThemeValidator()
        {
            RuleFor(x => x.tema_adi).NotEmpty().WithMessage("Tema adı boş geçilemez.")
                .Length(2, 10).WithMessage("Tema adı 2-10 karakter arsında olmalıdır.")
                .Matches(Utility.regexTR).WithMessage("Tema adı özel karakter içeremez.");
            RuleFor(x => x.ekleyen_id).NotEmpty().WithMessage("Ekleyen id boş geçilemez.");
            RuleFor(x => x.sil_id).NotEmpty().WithMessage("Sil id boş geçilemez.")
                .InclusiveBetween(0, 1).WithMessage("Sil id 0(pasif) yada 1(aktif) olamalıdır.");
        }
    }
}
