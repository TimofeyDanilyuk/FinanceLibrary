using FinanceLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FinanceLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public string TelegramNumber { get; set; }
        public string TLUserName { get; set; }
        public long TLChatId { get; set; }

        public List<Transaction> Transactions { get; set; } = new(); // Навигационное свойство
        public List<Budget> Budgets { get; set; } = new(); // Навигационное свойство
        public List<Category> Categories { get; set; } = new(); // Навигационное свойство

        public Category AddCategory(string name, TransactionType type)
        {
            var category = Category.Create(name, type, this);
            Categories.Add(category);
            return category;
        }
    }
}
