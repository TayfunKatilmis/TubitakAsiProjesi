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
    public class SoruImagesController : ControllerBase
    {
        ISoruImageService _soruImageService;
        public SoruImagesController(ISoruImageService soruImageService)
        {
            _soruImageService = soruImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile image, [FromForm] SoruImage img)
        {
            var result = _soruImageService.Add(image, img);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SoruImage img)
        {
            var result = _soruImageService.Delete(img);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile image, [FromForm] SoruImage img)
        {
            var result = _soruImageService.Update(image, img);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _soruImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
