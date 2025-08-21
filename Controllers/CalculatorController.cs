using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] double a, [FromQuery] double b)
        {
            var result = a + b;
            return Ok(new { Result = result });
        }

        [HttpGet("decrease")]
        public IActionResult GetDecrease([FromQuery] double a, [FromQuery] double b)
        {
            var result = a - b;
            return Ok(new { Result = result });
        }

        [HttpGet("divide")]
        public IActionResult GetDivide([FromQuery] double a, [FromQuery] double b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            else
            {
                double result = a / b;
                return Ok(new { Result = result });
            }
        }

        [HttpGet("mult")]
        public IActionResult GetMult([FromQuery] double a, [FromQuery] double b)
        {
            var result = a * b;
            return Ok(new { Result = result });
        }
    }
}