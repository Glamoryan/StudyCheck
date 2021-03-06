﻿using StudyCheck.Business.Abstract;
using StudyCheck.Business.Validations.FluentValidation;
using StudyCheck.Core.Aspects.Postsharp;
using StudyCheck.Core.Aspects.Postsharp.CacheAspects;
using StudyCheck.Core.Aspects.Postsharp.PerformanceAspects;
using StudyCheck.Core.Aspects.Postsharp.ValidationAspects;
using StudyCheck.Core.CrossCuttingConcerns.Caching.Microsoft;
using StudyCheck.DataAccess.Abstract;
using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudyCheck.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IUserDetailDal _userDetailDal;
        public UserManager(IUserDal userDal,IUserDetailDal userDetailDal)
        {
            _userDal = userDal;
            _userDetailDal = userDetailDal;
        }

        [FluentValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Uye AddUser(Uye uye)
        {
            _userDal.Add(uye);
            return uye;
        }

        [FluentValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Uye UpdateUser(Uye uye)
        {
            return _userDal.Update(uye);
        }

        [FluentValidationAspect(typeof(AccountValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Uyedetay AddUserDetail(Uyedetay uyedetay)
        {
            return _userDetailDal.Add(uyedetay);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Uyedetay> GetActiveAccounts()
        {
            return _userDetailDal.GetList(x => x.sil_id == 1);
        }
        
        /// <summary>
        /// Üye id 'sine göre ComplexType
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserDetail GetUserDetailById(int id)
        {
            return _userDal.GetUserDetails().Where(x => x.UyeId == id).SingleOrDefault();
        }

        [FluentValidationAspect(typeof(AccountValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Uyedetay UpdateUserDetail(Uyedetay uyedetay)
        {
            return _userDetailDal.Update(uyedetay);
        }

        /// <summary>
        /// Uyedetay complex type donduren Uyedetaylarını getir
        /// </summary>
        /// <returns>Uyedetay Complex Type</returns>
        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(3)]//3 saniyeden fazla gelirse        
        public List<UserDetail> GetAllUserDetails()
        {
            return _userDal.GetUserDetails();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(3)]//3 saniyeden fazla gelirse        
        public List<Uye> GetAllUsers()
        {            
            return _userDal.GetList();
        }

        public Uyedetay GetByUsernamePassword(string username, string password)
        {
            return _userDetailDal.Get(u => u.kullanici_adi.Equals(username) & u.kullanici_sifre.Equals(password));
        }

        public Uye GetUserById(int id)
        {
            return _userDal.Get(u => u.id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(3)]//3 saniyeden fazla gelirse      
        public List<Uyedetay> GetAllAdmins(int rolId)
        {
            return _userDetailDal.GetList(u => u.rol_id == rolId);
        }

        public List<Uyedetay> GetAllUyeDetay()
        {
            return _userDetailDal.GetList();
        }

        public void DeleteUser(Uye uye)
        {
            _userDal.Delete(uye);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(3)]//3 saniyeden fazla gelirse   
        public Uyedetay GetUyeDetayById(int id)
        {
            return _userDetailDal.Get(d => d.id == id);
        }
    }
}

