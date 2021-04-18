using log4net;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DbContextGenerator //: IDbContextGenerator
{
    private readonly DbContextOptions<dbBasicBilling> options;
    private static readonly ILog Log = LogManager.GetLogger(typeof(DbContextGenerator));
    public DbContextGenerator(DbContextOptions<dbBasicBilling> opt)
    {
        this.options = opt;
    }

    //public IDBBasicBilling GenerateMyDbContext()
    //{
    //    Log.Debug("My Db Context Created with Connection String: " + options);
    //    return new dbBasicBilling(options);
    //}

}
