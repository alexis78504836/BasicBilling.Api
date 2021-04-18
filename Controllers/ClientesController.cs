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
    public class ClientesController : ControllerBase
    {
        private readonly dbBasicBilling _db;
        public ClientesController(dbBasicBilling db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult GetAllPayments(){
            NClientes nClientes = new NClientes(_db);
            return Ok(nClientes.GetHistoryOfPayments());
        }
        [HttpGet("{Id}")]
        public ActionResult GetPaymentsByClientId(string Id){
            NClientes nClientes = new NClientes(_db);
            return Ok(nClientes.GetHistoryOfPaymentsPerClient(Id));
        }
        [HttpPut]
        public ActionResult PutBill(Bills bill){
            NClientes nClientes = new NClientes(_db);
            string mensaje = string.Empty;
            bool pagado = nClientes.PayBill(bill, ref mensaje);
            if(pagado){
                return Ok(true);
            }else{
                return Ok(new { status= false, message = mensaje});
            }
        }
    }
}
