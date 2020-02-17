using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator,object entity)
        {
            var sonuc = validator.Validate(entity);
            if (sonuc.Errors.Count > 0)
                throw new ValidationException(sonuc.Errors);
        }
    }
}
