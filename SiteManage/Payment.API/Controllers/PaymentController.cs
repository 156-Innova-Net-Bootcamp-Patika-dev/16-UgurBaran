using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {


        private readonly IPaymentService paymentService;

        public PaymentController(IPaymentService _paymentService)
        {
            paymentService = _paymentService;
        }
        //Get Payments
        [HttpGet]
        public IEnumerable<PaymentViewModel> Get()
        {
            return paymentService.Get();
        }
        //Get Payment By User Id
        [HttpGet("{id}")]
        public IEnumerable<PaymentViewModel> GetByUserId(int id)
        {
            return paymentService.GetByUserId(id);
        }
        //Insert Payment
        [HttpPost]
        public bool Insert([FromBody] PaymentInsertModel insertPayment)
        {
            return paymentService.Insert(insertPayment);
        }
    }
}
