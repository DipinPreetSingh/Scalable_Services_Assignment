using Microsoft.AspNetCore.Mvc;
using payment_service.services;
using payment_service.models;
using payment_service.routes;

namespace payment_service.controllers
{
    [ApiController]
    [Route(PaymentRoutes.Base)]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("process")]
        [Route(PaymentRoutes.ProcessPayment)]
        public async Task<IActionResult> ProcessPayment([FromBody] PaymentRequest request)
        {
            try
            {
                var result = await _paymentService.ProcessPayment(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        [Route(PaymentRoutes.GetPaymentById)]
        public IActionResult GetPaymentById(Guid id)
        {
            // Example implementation for retrieving a payment by ID
            return Ok(new { Message = "Payment details for " + id });
        }

        [HttpGet("all")]
        [Route(PaymentRoutes.GetAllPayments)]
        public IActionResult GetAllPayments()
        {
            // Example implementation for retrieving all payments
            return Ok(new { Message = "List of all payments" });
        }
    }
}
