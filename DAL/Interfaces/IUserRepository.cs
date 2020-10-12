using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUserRepository
    {
        UserModel GetUser(string username, string password);
        IEnumerable<UserModel> GetAll();
        UserModel GetById(int id);
    }
}
