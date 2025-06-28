using FinanceLibrary.Enum;
using FinanceLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary.Data
{
    public class FinanceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Budget> Budgets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        // Метод для получения категорий пользователя
        public IQueryable<Category> GetUserCategories(int userId, TransactionType? type = null)
        {
            var query = Categories.Where(c => c.UserId == userId);

            if (type != null)
                query = query.Where(c => c.Type == type);

            return query;
        }

        // Асинхронная версия
        public async Task<List<Category>> GetUserCategoriesAsync(int userId, TransactionType? type = null)
        {
            var query = Categories.Where(c => c.UserId == userId);

            if (type != null)
                query = query.Where(c => c.Type == type);

            return await query.ToListAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка связей и индексов
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.User)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<Budget>()
                .HasIndex(b => new { b.UserId, b.CategoryId, b.Month, b.Year })
                .IsUnique(); // Уникальный бюджет на категорию в месяц
        }
    }
}
