using FluentValidation;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Validations.FluentValidation
{
    public class StudyValidator:AbstractValidator<Calisma>
    {
        public StudyValidator()
        {
            RuleFor(x => x.uye_id).NotEmpty().WithMessage("Üye id boş geçilemez.");
            RuleFor(x => x.sinav_id).NotEmpty().WithMessage("Sınav id boş geçilemez.");
            RuleFor(x => x.ders_id).NotEmpty().WithMessage("Ders id boş geçilemez.");
            RuleFor(x => x.calisilan_zaman).NotEmpty().WithMessage("Çalışılan zaman boş geçilemez.");
            RuleFor(x => x.calisilan_tarih).NotEmpty().WithMessage("Çalışılan tarih boş geçilemez.");
        }
    }
}
