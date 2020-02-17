using StudyCheck.Core.DataAccess.EntityFramework;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework
{
    public class EfExamDal:EfEntityRepositoryBase<Sinav,StudyCheckContext>,IExamDal
    {
    }
}
