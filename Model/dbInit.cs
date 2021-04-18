using System;
using System.Linq;

public static class dbInit{
    public static void Initialize(dbBasicBilling context){
        context.Database.EnsureCreated();
        if(!context.Clients.Any()){
            Clients[] c = new Clients[5];
            Clients c1 = new Clients{ ClientsId="100" , Name= "Joseph Carlton"};
            c[0] = c1;
            Clients c2 = new Clients{ ClientsId="200" , Name= "Maria Juarez"};
            c[1] = c2;
            Clients c3 = new Clients{ ClientsId="300" , Name= "Albert Kenny"};
            c[2] = c3;
            Clients c4 = new Clients{ ClientsId="400" , Name= "Jessica Phillips"};
            c[3] = c4;
            Clients c5 = new Clients{ ClientsId="500" , Name= "Charles Johnson"};
            c[4] = c5;

            foreach(var cliente in c){
                context.Clients.Add(cliente);
            }
            context.SaveChanges();
        }

        if(!context.Services.Any()){
            Services[] services = new Services[3];
            Services s1 = new Services{ ServicesId=1, Name="Basic service" };
            services[0] = s1;
            Services s2 = new Services{ ServicesId=2, Name="Advanced service" };
            services[1] = s2;
            Services s3 = new Services{ ServicesId=3, Name="Medium service" };
            services[2] = s3;

            foreach(var service in services){
                context.Services.Add(service);
            }
            context.SaveChanges();
        }
        
        if(!context.Bills.Any()){
            for (int i = 0; i < 2; i++){
                Bills b = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 200,
                                     ClientsId = "100", ServicesId = 1 };
                Bills b1 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 200,
                                     ClientsId = "200", ServicesId = 1 };
                Bills b2 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 200,
                                     ClientsId = "300", ServicesId = 1 };
                Bills b3 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 200,
                                     ClientsId = "400", ServicesId = 1 };
                Bills b4 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 200,
                                     ClientsId = "500", ServicesId = 1 };                                     
                context.Bills.Add(b);
                context.Bills.Add(b1);
                context.Bills.Add(b2);
                context.Bills.Add(b3);
                context.Bills.Add(b4);
                context.SaveChanges();
            }
            for (int i = 0; i < 2; i++){
                Bills b = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 350,
                                     ClientsId = "100", ServicesId = 2 };
                Bills b1 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 350,
                                     ClientsId = "200", ServicesId = 2 };
                Bills b2 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 350,
                                     ClientsId = "300", ServicesId = 2 };
                Bills b3 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 350,
                                     ClientsId = "400", ServicesId = 2 };
                Bills b4 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 350,
                                     ClientsId = "500", ServicesId = 2 };
                context.Bills.Add(b);
                context.Bills.Add(b1);
                context.Bills.Add(b2);
                context.Bills.Add(b3);
                context.Bills.Add(b4);
                context.SaveChanges();
            }
            for (int i = 0; i < 2; i++){
                Bills b = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 175,
                                     ClientsId = "100", ServicesId = 3 };
                Bills b1 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 175,
                                     ClientsId = "200", ServicesId = 3 };
                Bills b2 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 175,
                                     ClientsId = "300", ServicesId = 3 };
                Bills b3 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 175,
                                     ClientsId = "400", ServicesId = 3 };
                Bills b4 = new Bills{ Periodo = (DateTime.Now.AddMonths(-i)).ToString("yyyyMM"),
                                     Estado = "Pending", Monto = 175,
                                     ClientsId = "500", ServicesId = 3 };
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