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
    public class ReverseItAlphanumeric : Controller
    {
       private readonly ReverseItAphanumericServices _reverseItAphanumericServices;
       public ReverseItAlphanumeric(ReverseItAphanumericServices reverseItAphanumericServices){
            _reverseItAphanumericServices = reverseItAphanumericServices;
       }
       [HttpGet]
       [Route("Reversestring/{input}")]

       public string reversestring(string input){
        string result = _reverseItAphanumericServices.reversestring(input);
        return result;
       }
    }
}