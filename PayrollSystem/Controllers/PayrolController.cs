using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Domain;

namespace PayrollSystem.Controllers;

[Route("api/[controller]")]
public class PayrolController : ControllerBase
{
    [HttpPost("Caclulator")]
    public ActionResult<decimal> Calculate(Employee employee)
    {
        var calculator = new PayrolCalculator();
        return Ok(calculator.Calculate(employee));
    }
}