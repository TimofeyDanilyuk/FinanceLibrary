using FinanceLibrary.Enum;

namespace FinanceLibrary.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TransactionType Type { get; set; } // Enum (Income/Expense)
        public List<Transaction> Transactions { get; set; } = new(); // Навигационное свойство
        public List<Budget> Budgets { get; set; } = new(); // Навигационное свойство
    }
}