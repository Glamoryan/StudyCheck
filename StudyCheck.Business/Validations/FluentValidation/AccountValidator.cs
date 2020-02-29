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
    public class AccountValidator:AbstractValidator<Uyedetay>
    {        
        public AccountValidator()
        {
            RuleFor(x => x.uye_id).NotEmpty().WithMessage("UyeId boş geçilemez.");
            RuleFor(x => x.kullanici_adi).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez.")
                .Length(5, 10).WithMessage("Kullanıcı adı 5-10 karakter arasında olmalıdır.")
                .Matches(Utility.regex).WithMessage("Kullanıcı adı özel karakterler içeremez.");
            RuleFor(x=>x.kullanici_sifre).NotEmpty().WithMessage("Kullanıcı şifresi boş geçilemez.")
                .Length(8,15).WithMessage("Kullanıcı şifresi 8-15 karakter arasında olmalıdır.")
                .Matches(Utility.regex).WithMessage("Kullanıcı şifresi özel karakterler içeremez.");
            RuleFor(x => x.kullanici_mail).NotEmpty().WithMessage("Kullanıcı maili boş geçilemez.")
                .EmailAddress().WithMessage("Geçersiz mail adresi");
            RuleFor(x => x.sil_id).NotEmpty().WithMessage("Bu alan boş geçilemez.")
                .InclusiveBetween(0, 1).WithMessage("Sil id 0(pasif) yada 1(aktif) olmalıdır.");
            RuleFor(x => x.tema_id).NotEmpty().WithMessage("Tema id boş geçilemez.");
            RuleFor(x => x.rol_id).NotEmpty().WithMessage("Rol id boş geçilemez.");

        }
    }
}
