using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class dbBasicBilling : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=dbBasicBilling.sqlite");
    
    public virtual DbSet<Bills> Bills { get; set; }
    public virtual DbSet<Clients> Clients { get; set; }
    public virtual DbSet<Services> Services { get; set; }

}