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
    public class CevapController : ControllerBase
    {
        ICevapService _cevapService;

        public CevapController(ICevapService cevapService)
        {
            _cevapService = cevapService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _cevapService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Cevap cevap)
        {
            var result = _cevapService.Add(cevap);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete]
        public IActionResult Delete(Cevap cevap)
        {
            var result = _cevapService.Delete(cevap);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Cevap cevap)
        {

            var result = _cevapService.Update(cevap);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
