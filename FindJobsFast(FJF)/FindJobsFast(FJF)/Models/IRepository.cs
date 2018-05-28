using System.Collections.Generic;

namespace FindJobsFast_FJF_.Models
{
    public interface IRepository
    {
        IEnumerable<ApplicationUser> GetUsers();
    }
}