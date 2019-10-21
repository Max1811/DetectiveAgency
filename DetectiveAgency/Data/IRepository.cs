using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetectiveAgency.Models
{
    public interface IRepository
    {
        User GetUser(int ID);
        IEnumerable<User> GetAllUsers();
        User Add(User user);
        User Update(User userChange);
        User Delete(int ID);

    }
}
