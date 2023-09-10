using Microsoft.EntityFrameworkCore;
using WebApplication10.Data.Entity;
namespace WebApplication10.Data
{
    public class MyContextUsers:DbContext
    {
        public MyContextUsers(DbContextOptions option ) :base (option) 
        {

        }
        public DbSet<UserRegistrationcs> Users { get;set; } 
    }
}
