using FinanceLibrary.Enum;

namespace FinanceLibrary.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TransactionType Type { get; set; } // Enum (Income/Expense)

        public int UserId { get; set; }
        public User User { get; set; }

        public List<Transaction> Transactions { get; set; } = new(); // Навигационное свойство
        public List<Budget> Budgets { get; set; } = new(); // Навигационное свойство

        public static Category Create(string name, TransactionType type, User user)
        {
            return new Category
            {
                Name = name,
                Type = type,
                UserId = user.Id,
                User = user
            };
        }
    }
}