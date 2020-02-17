using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Abstract
{
    public interface IThemeService
    {
        List<Tema> GetAllThemes();
        Tema GetThemeById(int id);
        List<Tema> GetActiveThemes();
        Tema AddTheme(Tema tema);
        Tema UpdateTheme(Tema tema);
    }
}
