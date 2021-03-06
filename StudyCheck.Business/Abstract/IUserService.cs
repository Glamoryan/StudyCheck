﻿using StudyCheck.Entites.ComplexTypes;
using StudyCheck.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Business.Abstract
{
    public interface IUserService
    {
        List<UserDetail> GetAllUserDetails();
        List<Uye> GetAllUsers();
        UserDetail GetUserDetailById(int id);
        Uye AddUser(Uye uye);
        Uye UpdateUser(Uye uye);
        Uye GetUserById(int id);
        Uyedetay GetUyeDetayById(int id);
        Uyedetay AddUserDetail(Uyedetay uyedetay);
        Uyedetay UpdateUserDetail(Uyedetay uyedetay);
        List<Uyedetay> GetActiveAccounts();
        Uyedetay GetByUsernamePassword(string username,string password);
        List<Uyedetay> GetAllAdmins(int rolid);
        List<Uyedetay> GetAllUyeDetay();
        void DeleteUser(Uye uye);
    }
}
