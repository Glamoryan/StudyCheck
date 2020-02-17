using StudyCheck.Core.DataAccess;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.DataAccess.Abstract
{
    public interface IStudyDal:IEntityRepository<Calisma>
    {
    }
}
