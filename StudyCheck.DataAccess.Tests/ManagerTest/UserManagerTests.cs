using System;
using System.Threading;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StudyCheck.Business.Concrete.Managers;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.Entites.Concrete;

namespace StudyCheck.DataAccess.Tests.ManagerTest
{
    [TestClass]
    public class UserManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Uye_validasyon_kontrol()
        {
            Mock<IUserDal> mock = new Mock<IUserDal>();
            Mock<IUserDetailDal> mockDet = new Mock<IUserDetailDal>();
            UserManager userManager = new UserManager(mock.Object, mockDet.Object);
            userManager.UpdateUser(new Uye());
        }
        [TestMethod]
        public void Performance_check()
        {
            Mock<IUserDal> mock = new Mock<IUserDal>();
            Mock<IUserDetailDal> mockDet = new Mock<IUserDetailDal>();
            UserManager userManager = new UserManager(mock.Object, mockDet.Object);
            userManager.GetAllUsers();
            

        }
    }
}
