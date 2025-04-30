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
        public decimal Amount { get; set; } // Сумма (положительная/отрицательная)
        public DateTime Date { get; set; }  // Дата операции
        public string Description { get; set; } // Описание (например, "Продукты в Пятерочке")

        // Внешние ключи
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Навигационное свойство

        public int UserId { get; set; }
        public User User { get; set; } // Навигационное свойство
    }
}
