using DAL.Helper;
using Model;
using Helper;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class UserRepository : IUserRepository
    {
        private IDatabaseHelper _dbHelper;
        public UserRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<UserModel> _users = new List<UserModel>
        {
            new UserModel { Id = 1, FirstName = "Đông", LastName = "Nguyễn Hữu", Username = "admin", Password = "admin", Role = Role.Admin },
            new UserModel { Id = 2, FirstName = "Huệ", LastName = "Nguyễn Thị Thanh", Username = "user", Password = "user", Role = Role.User },
            new UserModel { Id = 3, FirstName = "Thảo", LastName = "Nguyễn Diệu", Username = "user1", Password = "user1", Role = Role.User },
            new UserModel { Id = 4, FirstName = "Khôi", LastName = "Nguyễn Minh", Username = "user2", Password = "user2", Role = Role.User }
        }; 

        public UserModel GetUser(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);
            // return null if user not found
            if (user == null)
                return null;
            return user; 
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _users.WithoutPasswords();
        }

        public UserModel GetById(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user.WithoutPassword();
        }

    }
}
