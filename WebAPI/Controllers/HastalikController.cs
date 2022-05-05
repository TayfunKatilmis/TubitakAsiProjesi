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
    public class HastalikController : ControllerBase
    {
        IHastalikService _hastalikService;

        public HastalikController(IHastalikService hastalikService)
        {
            _hastalikService = hastalikService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _hastalikService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Hastalik hastalik)
        {
            var result = _hastalikService.Add(hastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete]
        public IActionResult Delete(Hastalik hastalik)
        {
            var result = _hastalikService.Delete(hastalik);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Hastalik hastalik)
        {

            var result = _hastalikService.Update(hastalik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
