using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoListContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Item> Items { get; set; }

        public ToDoListContext(DbContextOptions options = null) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=todolist;uid=root;pwd=root;");
    }
}