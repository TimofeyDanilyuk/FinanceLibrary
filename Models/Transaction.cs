using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; } // Сумма
        public DateTime Date { get; set; }  // Дата операции
        public string Description { get; set; } // Описание

        // Внешние ключи
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        public Category Category { get; set; } // Навигационное свойство
        public User User { get; set; } // Навигационное свойство
    }
}
