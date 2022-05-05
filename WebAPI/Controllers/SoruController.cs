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
    public class SoruController : ControllerBase
    {
        ISoruService _soruService;

        public SoruController(ISoruService soruService)
        {
            _soruService = soruService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _soruService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Soru soru)
        {
            var result = _soruService.Add(soru);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete]
        public IActionResult Delete(Soru soru)
        {
            var result = _soruService.Delete(soru);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Soru soru)
        {

            var result = _soruService.Update(soru);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
