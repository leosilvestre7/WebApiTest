using System;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Data.Interfaces;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseResultController : ControllerBase
    {
        private readonly IApiRepository _repository;

        public CourseResultController(IApiRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetCourseResultsAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CourseResult courseResult)
        {
            courseResult.State = true;
            courseResult.CreationDate = DateTime.Now;

            _repository.Add(courseResult);
            if (await _repository.SaveAll())
                return Ok(courseResult);
            return BadRequest();
        }

    }
}
