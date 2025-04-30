namespace FinanceLibrary.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public decimal LimitAmount { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Внешние ключи
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        public Category Category { get; set; } // Навигационное свойство
        public User User { get; set; } // Навигационное свойство
    }
}