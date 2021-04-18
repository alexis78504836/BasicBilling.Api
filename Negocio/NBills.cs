using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


public class NBills{    
    private dbBasicBilling _db;
    public NBills(dbBasicBilling db){
        _db = db;
    }
    public Client GetClientById(string Id) {
        return _db.Clients.Where(_ => _.clientId == Id).FirstOrDefault();
    }
    public bool Create(Bills _b){
        var clients = _db.Clients.ToList();
        bool allCreated = true;
        foreach (var client in clients)
        {
            Bills b = new Bills{ clientId = client.clientId, 
                                period = _b.period,
                                Category = _b.Category,
                                Monto = 100,
                                Estado = "Pending"};
            var existeBill = _db.Bills.Where(_ => _.Category == b.Category
                                                    && _.clientId == b.clientId
                                                    && _.period == b.period).Any(); 
            if(!existeBill){
                _db.Bills.Add(b);
            }else{
                allCreated = false;
            }
            
        }
        _db.SaveChanges();
        return allCreated;
    }
    public List<Bills> search(string category){
        var result = _db.Bills.Where(_ => _.Category == category).ToList();
        return result;
    }
    public List<Bills> GetPendingBillsPerClient(string clientId){
        try
        {
            var result = _db.Bills.Where(_ => _.clientId == clientId 
                                                && _.Estado == "Pending")
                                                .ToList();
            return result;
        }
        catch
        {
            throw;
        }
    }
    public List<Bills> GetHistoryOfPaymentsPerClient(string clientId){
        try
        {
            var result = _db.Bills.Where(_ => _.clientId == clientId 
                                                && _.Estado != "Pending")
                                                .OrderByDescending(_ => _.period).ToList();
            return result;
        }
        catch
        {
            throw;
        }
    }
    public List<Bills> GetHistoryOfPayments(){
        try
        {
            var result = _db.Bills.Where(_ => _.Estado != "Pending")
                                                .OrderByDescending(_ => _.period).ToList();
            return result;
        }
        catch
        {
            throw;
        }
    }
    public bool PayBill(Bills _bill,ref string mensaje){
        try
        {
            var bill = _db.Bills.Where(_ => _.clientId == _bill.clientId
                                            && _.Category == _bill.Category
                                            && _.period == _bill.period).FirstOrDefault();
            
            var sePuedePagar = SePuedePagar(bill,_bill.Monto,ref mensaje);
            if(!sePuedePagar){
                return false;
            }
            bill.Estado = "Paid";
            _db.Bills.Update(bill);
            _db.SaveChanges();
            return true;
        }
        catch
        {
            throw;
        }
    }
    private bool SePuedePagar(Bills bill, double monto, ref string mensaje){
        if(bill == null){
            mensaje = "There is no Bill registered.";
            return false;
        }
        if(bill.Estado == "Paid"){
            mensaje = "The bill has already been paid.";
            return false;
        }
        
        return true;
    }
}