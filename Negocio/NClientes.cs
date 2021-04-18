using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


public class NClientes{    
    private dbBasicBilling _db;
    public NClientes(dbBasicBilling db){
        _db = db;
    }
    public Clients GetClientById(string Id) {
        return _db.Clients.Where(_ => _.ClientsId == Id).FirstOrDefault();
    }
    public List<Bills> GetPendingBillsPerClient(string clientId){
        try
        {
            var result = _db.Bills.Where(_ => _.ClientsId == clientId 
                                                && _.Estado == "Pending")
                                                .Include(_ => _.Services).ToList();
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
            var result = _db.Bills.Where(_ => _.ClientsId == clientId 
                                                && _.Estado != "Pending")
                                                .Include(_ => _.Services)
                                                .OrderByDescending(_ => _.Periodo).ToList();
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
                                                .Include(_ => _.Services)
                                                .OrderByDescending(_ => _.Periodo).ToList();
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
            var bill = _db.Bills.Where(_ => _.ClientsId == _bill.ClientsId 
                                                    && _.ServicesId == _bill.ServicesId
                                                    && _.Periodo == _bill.Periodo).FirstOrDefault();
            
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
        if(bill.Monto <= 0){
            mensaje = "Enter the amount.";
            return false;
        }
        if(monto < bill.Monto){
            mensaje = $"Please enter the amount of { bill.Monto }";
            return false;
        }
        return true;
    }
}