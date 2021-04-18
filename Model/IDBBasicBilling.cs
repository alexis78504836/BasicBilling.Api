using Microsoft.EntityFrameworkCore;
using System;

public interface IDBBasicBilling : IDisposable
{
    int SaveChanges();
    DbSet<Clients> Clients { get; set; }
}
