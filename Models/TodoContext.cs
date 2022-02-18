using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TodoOnboardApi.Models;

namespace TodoOnboardApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
         public DbSet<Board> Board { get; set; } = null!;

        // public DbSet<TodoOnboardApi.Models.Board> Board { get; set; }
    }
}