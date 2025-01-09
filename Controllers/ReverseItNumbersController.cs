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
    public class ReverseItNumbersController : Controller
    {
       private readonly ReverseItNumberServices _reverseItNumberServices;
       public ReverseItNumbersController(ReverseItNumberServices reverseItNumberServices){
        _reverseItNumberServices = reverseItNumberServices;
       }
       [HttpGet]
       [Route("Reversenumber/{Number1}")]

        public string ReverseNumbers(string Number1){
            
            return _reverseItNumberServices.ReverseNumbers(Number1);
        }

    }
}