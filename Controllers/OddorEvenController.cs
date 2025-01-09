using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FiveToSeven.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FiveToSeven.Controllers
{
    [Route("[controller]")]
    public class OddorEvenController : Controller
    {
       private readonly OddOrEvenServices _oddOrEvenServices;

       public OddorEvenController(OddOrEvenServices oddOrEvenServices){
        _oddOrEvenServices = oddOrEvenServices;
       }
       [HttpGet]
       [Route("OddOrEven/{Number1}")]
       public string OddOrEvenResult(string Number1){
        string OddOrEvenResult = _oddOrEvenServices.OddOrEvenResult(Number1);
        return OddOrEvenResult;
       }
    }
}