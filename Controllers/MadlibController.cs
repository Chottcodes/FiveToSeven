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
    public class MadlibController : Controller
    {
        private readonly MadlibServices _madlibServices;
        public MadlibController(MadlibServices madlibServices)
        {
            _madlibServices = madlibServices;
        }

        [HttpGet]
        [Route("Madlib/{cityName}/{favBacketballTeam}/{favFood}/{dreamCar}/{favCartoonChar}/{favVideoGame}/{famousPersonNamefamousPersonName}/{adjective}/{animeCharacter}/{animal}")]

        public string FunnyMadlib(string cityName, string favBacketballTeam, string favFood, string dreamCar,string favCartoonChar, string favVideoGame,string famousPersonName,string adjective,string animeCharacter,string animal){
            string MadlibResult = _madlibServices.FunnyMadlib(cityName,  favBacketballTeam,  favFood,  dreamCar, favCartoonChar,  favVideoGame, famousPersonName, adjective, animeCharacter,animal);
            return MadlibResult;
        }






    }

}