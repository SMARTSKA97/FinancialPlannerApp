using Microsoft.EntityFrameworkCore;
namespace FinancialPlanner.Data.Contexts{
    public class FinancialPlannerContext : DbContext{
        public FinancialPlannerContext(DbContextOptions<FinancialPlannerContext> options) : base(options){}
    }
}