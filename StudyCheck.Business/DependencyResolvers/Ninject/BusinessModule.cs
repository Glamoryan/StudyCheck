using Ninject.Modules;
using StudyCheck.Business.Abstract;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IExamService>().To<ExamManager>().InSingletonScope();
            Bind<ILessonService>().To<LessonManager>().InSingletonScope();
            Bind<IRightService>().To<RightManager>().InSingletonScope();
            Bind<IRoleService>().To<RoleManager>().InSingletonScope();
            Bind<IStudiesService>().To<StudyManager>().InSingletonScope();
            Bind<IThemeService>().To<ThemeManager>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();

            Bind<IExamDal>().To<EfExamDal>().InSingletonScope();
            Bind<ILessonDal>().To<EfLessonDal>().InSingletonScope();
            Bind<IRightDal>().To<EfRightDal>().InSingletonScope();
            Bind<IRolDal>().To<EfRolDal>().InSingletonScope();
            Bind<IStudyDal>().To<EfStudyDal>().InSingletonScope();
            Bind<IThemeDal>().To<EfThemeDal>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();
            Bind<IUserDetailDal>().To<EfUserDetailDal>().InSingletonScope();
        }
    }
}
