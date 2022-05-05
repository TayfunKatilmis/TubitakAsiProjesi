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
    public class AnasayfaController : ControllerBase
    {
        IAnasayfaService _anasayfaService;

        public AnasayfaController(IAnasayfaService anasayfaService)
        {
            _anasayfaService = anasayfaService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _anasayfaService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Anasayfa anasayfa)
        {
            var result = _anasayfaService.Add(anasayfa);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpDelete]
        public IActionResult Delete(Anasayfa anasayfa)
        {
            var result = _anasayfaService.Delete(anasayfa);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Anasayfa anasayfa)
        {

            var result = _anasayfaService.Update(anasayfa);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
