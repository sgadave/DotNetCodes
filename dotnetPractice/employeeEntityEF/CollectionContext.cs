using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL;

public class CollectionContext:DbContext{

    public DbSet<Employee>? Employees{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string conString =@"server=localhost;port=3306;user=Swapnil;password=Swapnil@99;database=dotnet";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>(entity =>{
          entity.HasKey(e=>e.Id);
          entity.Property(e=>e.Salary).IsRequired();
          entity.Property(e=>e.Name).IsRequired();
          entity.Property(e=>e.Experience).IsRequired();
        });
        modelBuilder.Entity<Employee>().ToTable("EmpTable");
    }
}
