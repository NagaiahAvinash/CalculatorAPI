using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]

    public class Calculator : ControllerBase
    {
        // we can use the below logic for addition and We need to call the "Addition" function while running.
        [HttpGet("Addition")]
        public ActionResult<decimal> Addition(decimal x, decimal y)
        {
            // sum is a variable and the value of x plus y will be saved in "sum" variable
            var sum = x + y;
            // below code will return the sum and will display only the value inside sum variable when we call the api.
            return Ok(sum);
        }
//  below is the logic for subtraction.
        [HttpGet("Subtraction")]
        public ActionResult<decimal> Subtraction(decimal x, decimal y)
        {
            // calculation is done and being saved in the variable named "difference"
            var difference = x - y;
            // below will return the value of difference.
            return Ok(difference);
        }
        //  below is the code for multiplication logic.
        [HttpGet("Multiplication")]
        public ActionResult<decimal> Multiplication(decimal x, decimal y)
        {
            // below will make the calculation for multiplication and will save the result in variable named product.
            var product = x * y;
            // below will return the value of product.
            return Ok(product);
        }
        // below is the logic for Division. 
        [HttpGet("Division")]
        public ActionResult<decimal> Division(decimal x, decimal y)
        {
            // below we check if the denominator is equal to zero as it will result in infinite. it will only enter if it is not equal to zero
            if (y == 0)
            {
                // below message will be displayed when the denominator is equal to zero
                return BadRequest("Division by zero is not allowed.");
            }
            // result is stored in the variable called quotient when the denominator/y is not equal to zero
            var quotient = x / y;
            // below will return the value of quotient
            return Ok(quotient);
        }
        // belowe is the logic for modulus operation
        [HttpGet("Modulus")]
        public ActionResult<decimal> Modulus(decimal x, decimal y)
        {
            // same as before we check if the denominator is equal to zero or not as it will result in infinite value.
            if (y == 0)
            {
                // if the denominator is equal to zero, then the below message will be displayed
                return BadRequest("Modulus by zero is not allowed.");
            }
            // below is the variable named remainder where the modulus operation is done and results are saved.
            var remainder = x % y;
            // below will return the value of remainder. 
            return Ok(remainder);
        }
    }
}


