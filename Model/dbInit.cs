using System;
using System.Linq;

public static class dbInit{
    public static void Initialize(dbBasicBilling context){
        context.Database.EnsureCreated();
        if(!context.Clients.Any()){
            Client[] c = new Client[5];
            Client c1 = new Client{ clientId="100" , Name= "Joseph Carlton"};
            c[0] = c1;
            Client c2 = new Client{ clientId="200" , Name= "Maria Juarez"};
            c[1] = c2;
            Client c3 = new Client{ clientId="300" , Name= "Albert Kenny"};
            c[2] = c3;
            Client c4 = new Client{ clientId="400" , Name= "Jessica Phillips"};
            c[3] = c4;
            Client c5 = new Client{ clientId="500" , Name= "Charles Johnson"};
            c[4] = c5;

            foreach(var cliente in c){
                context.Clients.Add(cliente);
            }
            context.SaveChanges();
        }

        
        if(!context.Bills.Any()){
            for (int i = 0; i < 2; i++){
                Bills b = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 300,
                                     clientId = "100", Category= "SEWER"};
                Bills b1 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 200,
                                     clientId = "200", Category= "SEWER" };
                Bills b2 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 100,
                                     clientId = "300", Category= "SEWER" };
                Bills b3 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 130,
                                     clientId = "400", Category= "SEWER" };
                Bills b4 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 230,
                                     clientId = "500", Category= "SEWER" };                                     
                context.Bills.Add(b);
                context.Bills.Add(b1);
                context.Bills.Add(b2);
                context.Bills.Add(b3);
                context.Bills.Add(b4);
                context.SaveChanges();
            }
            for (int i = 0; i < 2; i++){
                Bills b = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 350,
                                     clientId = "100", Category= "WATER" };
                Bills b1 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 123,
                                     clientId = "200", Category= "WATER" };
                Bills b2 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 322,
                                     clientId = "300", Category= "WATER" };
                Bills b3 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 140,
                                     clientId = "400", Category= "WATER" };
                Bills b4 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 100,
                                     clientId = "500", Category= "WATER" };
                context.Bills.Add(b);
                context.Bills.Add(b1);
                context.Bills.Add(b2);
                context.Bills.Add(b3);
                context.Bills.Add(b4);
                context.SaveChanges();
            }
            for (int i = 0; i < 2; i++){
                Bills b = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 150,
                                     clientId = "100", Category= "ELECTRICITY" };
                Bills b1 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 175,
                                     clientId = "200", Category= "ELECTRICITY" };
                Bills b2 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 120,
                                     clientId = "300", Category= "ELECTRICITY" };
                Bills b3 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 100,
                                     clientId = "400", Category= "ELECTRICITY" };
                Bills b4 = new Bills{ period = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 230,
                                     clientId = "500", Category= "ELECTRICITY" };
                context.Bills.Add(b);
                context.Bills.Add(b1);
                context.Bills.Add(b2);
                context.Bills.Add(b3);
                context.Bills.Add(b4);
                context.SaveChanges();                                     
            }
        }
    }
}