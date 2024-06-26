using Microsoft.EntityFrameworkCore;

namespace Expensely.Models
{
    public class ExpenselyDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpenselyDbContext(DbContextOptions<ExpenselyDbContext> options)
            :base(options) 
        {
                
        }
    }
}
