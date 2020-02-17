using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Abstract
{
    public interface IRoleService
    {
        Rol AddRole(Rol rol);
        Rol UpdateRole(Rol rol);
        List<Rol> GetAllRoles();
        Rol GetRoleById(int id);
        List<Rol> GetAllRolesByRightId(int yetkiId);
        List<Rol> GetActiveRoles();
    }
}
