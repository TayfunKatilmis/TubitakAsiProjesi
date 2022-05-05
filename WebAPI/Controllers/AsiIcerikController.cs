using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsiIcerikController : ControllerBase
    {
        IAsiIcerikService _asiIcerikService;

        public AsiIcerikController(IAsiIcerikService asiIcerikService)
        {
            _asiIcerikService = asiIcerikService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _asiIcerikService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(AsiIcerik asiIcerik)
        {
            var result = _asiIcerikService.Add(asiIcerik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete]
        public IActionResult Delete(AsiIcerik asiIcerik)
        {
            var result = _asiIcerikService.Delete(asiIcerik);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(AsiIcerik asiIcerik)
        {

            var result = _asiIcerikService.Update(asiIcerik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
