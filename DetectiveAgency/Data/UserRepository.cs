using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetectiveAgency.Models
{
    public class UserRepository : IRepository
    {

        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public User Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User Delete(int ID)
        {
            User user = context.Users.Find(ID);
            if(user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            
            return user;
        }


        public IEnumerable<User> GetAllUsers()
        {
            return context.Users;
        }

        public User GetUser(int ID)
        {
            User user = context.Users.Find(ID);
            return user;
        }

        public User Update(User userChange)
        {
            var user = context.Users.Attach(userChange);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return userChange;
        }
    }
}
