using Ispit.API.Models;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Ispit.API.Models;

namespace Ispit.API.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoList> TodoLists { get; set; }
    }
}
