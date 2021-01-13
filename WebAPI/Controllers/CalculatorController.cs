using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharedOperations;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("adicao/{numeroUm}/{numeroDois}")]
        public IActionResult Add(int numeroUm, int numeroDois)
        {
            return Ok(BasicOperations.Add(numeroUm, numeroDois));
        }

        [HttpGet("subtracao/{numeroUm}/{numeroDois}")]
        public IActionResult Sub(int numeroUm, int numeroDois)
        {
            return Ok(BasicOperations.Sub(numeroUm, numeroDois));
        }

        [HttpGet("multiplicacao/{numeroUm}/{numeroDois}")]
        public IActionResult Mult(int numeroUm, int numeroDois)
        {
            return Ok(BasicOperations.Mult(numeroUm, numeroDois));
        }

        [HttpGet("divisao/{numeroUm}/{numeroDois}")]
        public IActionResult Div(int numeroUm, int numeroDois)
        {
            return Ok(BasicOperations.Div(numeroUm, numeroDois));
        }
    }
}
