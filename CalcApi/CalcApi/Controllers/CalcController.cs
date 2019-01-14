using System;
using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace CalcApi.Controllers
{
    /*     I'd use something like nlog for logging. I didn't set it up for this app         */
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private ICalculatorService _calculatorService { get; }

        public CalcController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        [ResponseCache(Duration = Int32.MaxValue)]
        public JsonResult Add(decimal n1, decimal n2)
        {
            return new JsonResult(_calculatorService.Add(n1, n2));
        }

        [HttpGet("substract")]
        [ResponseCache(Duration = Int32.MaxValue)]
        public JsonResult Substract(decimal n1, decimal n2)
        {
            return new JsonResult(_calculatorService.Substract(n1, n2));
        }

        [HttpGet("multiply")]
        [ResponseCache(Duration = Int32.MaxValue)]
        public JsonResult Multiply(decimal n1, decimal n2)
        {
            return new JsonResult(_calculatorService.Multiply(n1, n2));
        }

        [HttpGet("divide")]
        [ResponseCache(Duration = Int32.MaxValue)]
        public JsonResult Divide(decimal n1, decimal n2)
        {
            return new JsonResult(_calculatorService.Divide(n1, n2));
        }
    }
}
