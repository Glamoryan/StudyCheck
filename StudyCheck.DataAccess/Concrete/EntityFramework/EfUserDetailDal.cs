using StudyCheck.Core.DataAccess.EntityFramework;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Concrete.EntityFramework
{
    public class EfUserDetailDal : EfEntityRepositoryBase<Uyedetay, StudyCheckContext>, IUserDetailDal
    {
        
    }
}
