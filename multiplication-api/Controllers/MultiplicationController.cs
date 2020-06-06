using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace multiplication_api.Controllers
{
    public class MultiplicationController : ControllerBase
    {
        private readonly IMultiplier _multiplier;

        public MultiplicationController(IMultiplier multiplier)
        {
            _multiplier = multiplier;
        }
        
        [HttpGet("/multiply")]
        public IActionResult Multiply([FromQuery]int lhs, [FromQuery]int rhs)
        {
            return Ok(_multiplier.MultiplyNumbers(lhs, rhs));
        }
    }
}