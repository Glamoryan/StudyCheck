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
    public class RoleValidator:AbstractValidator<Rol>
    {        
        public RoleValidator()
        {
            RuleFor(x => x.yetki_id).NotEmpty().WithMessage("Yetki id boş geçilemez.");
            RuleFor(x => x.rol_adi).NotEmpty().WithMessage("Rol adı boş geçilemez.")
                .Length(2, 10).WithMessage("Rol adı 2-10 karakter arasında olmalıdır.")
                .Matches(Utility.regex).WithMessage("Rol adı özel karakter içeremez.");
            RuleFor(x => x.ekleyen_id).NotEmpty().WithMessage("Ekleyen id boş geçilemez.");
            RuleFor(x => x.sil_id).NotEmpty().WithMessage("Sil id boş geçilemez.")
                .InclusiveBetween(0, 1).WithMessage("Sil id 0(pasif) yada 1(aktif) olmalıdır.");

        }
    }
}
