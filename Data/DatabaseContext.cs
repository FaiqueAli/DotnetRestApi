using Microsoft.EntityFrameworkCore;
using testreactapp.Model;

namespace testreactapp.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions <DatabaseContext> opt) :base (opt)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}