namespace PetsForSaleWebAPI.EFCore;

public class EFDataContext:DbContext
{
    public EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
    {        
    }
    public DbSet<PetsCategory> PetsCategories { get; set; } 
}
