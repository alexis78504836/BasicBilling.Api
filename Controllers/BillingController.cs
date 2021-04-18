using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
namespace BasicBilling.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillingController : ControllerBase
    {
        private readonly dbBasicBilling _db;
        public BillingController(dbBasicBilling db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult GetAllPayments(){
            NBills bills = new NBills(_db);
            return Ok(bills.GetHistoryOfPayments());
        }
        [HttpGet("{ClientId}")]
        public ActionResult GetPaymentsByClientId(string ClientId){
            NBills bills = new NBills(_db);
            return Ok(bills.GetHistoryOfPaymentsPerClient(ClientId));
        }
        [HttpGet()]
        [Route("pending")]
        public ActionResult GetPendingBillsByClientId(string ClientId){
            NBills bills = new NBills(_db);
            return Ok(bills.GetPendingBillsPerClient(ClientId));
        }
        [HttpPost]
        [Route("pay")]
        public ActionResult PostBill(Bills bill){
            NBills bills = new NBills(_db);
            string mensaje = string.Empty;
            bool pagado = bills.PayBill(bill, ref mensaje);
            if(pagado){
                return Ok(true);
            }else{
                return Ok(new { status= false, message = mensaje});
            }
        }
        [HttpPost]
        [Route("bills")]
        public ActionResult PostBills(Bills bill){
            NBills bills = new NBills(_db);
            string mensaje = string.Empty;
            bool allCreated = bills.Create(bill);
            if(allCreated){
                return Ok(true);
            }else{
                return Ok(new { status= false, message = "Not all the bills were created because some of them alraedy exists."});
            }
        }
        [HttpGet()]
        [Route("search")]
        public ActionResult search(string category){
            NBills bills = new NBills(_db);
            return Ok(bills.search(category));
        }
    }
}
