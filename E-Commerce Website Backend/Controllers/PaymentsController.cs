using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceBackendAPI.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentsController : ControllerBase
    {
        [HttpPost]
        public IActionResult MakePayment([FromBody] object paymentData)
        {
            return Ok(new
            {
                Status = "Success",
                Message = "Payment processed successfully.",
                PaymentId = Guid.NewGuid().ToString()
            });
        }
    }
}
