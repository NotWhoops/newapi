using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewApiController : ControllerBase
    {
        //"readonly" means it can only be set in the constructor
        private readonly NewApiServices _newApiService;


        public NewApiController(NewApiServices newApiService)
        {
            _newApiService = newApiService;
        }

        [HttpGet]
        [Route("RPSRandom")]

        public string RPSSelection()
        {
            return _newApiService.RPSRandom();
        }   
    }
}