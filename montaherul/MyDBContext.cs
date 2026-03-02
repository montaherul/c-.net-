using Microsoft.EntityFrameworkCore;
using montaherul.Models;

namespace montaherul
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options)
    : base(options)
        {
        }

        public DbSet<StudentModel> Students { get; set; }

    }
}
