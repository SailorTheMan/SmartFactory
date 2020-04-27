using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Models.Repository
{
    public class Repository
    {
        private DBlayer context = new DBlayer();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }

        public void CreateUser(User newUser)
        {
            context.Users.Add(newUser);
            context.SaveChanges();
        }

        ///Мб в будущем пригодится

        public User GetUserByEmail(string email) => context.Users.FirstOrDefault(p => p.Email == email);
        public void EditPassword(User user)
        {
            User target = GetUserByEmail(user.Email);
            target.Password = user.Password;
            context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            var user = context.Users.FirstOrDefault(u => u.ID == id);
            if (user != null)
                context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
