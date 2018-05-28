using System.Collections.Generic;
using System.Linq;

namespace FindJobsFast_FJF_.Models
{
    public class UserRepository : IRepository
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<ApplicationUser> GetUsers()
        {
            return context.Set<ApplicationUser>().ToList();
        }
    }
}