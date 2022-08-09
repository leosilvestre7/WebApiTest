using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Data.Interfaces;
using WebApiTest.Dtos;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseResultController : ControllerBase
    {
        private readonly IApiRepository _repository;
        private readonly IMapper _mapper;

        public CourseResultController(IApiRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetCourseResultsAsync();
        
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CourseResultCreateDto courseResultDto)
        {
           /* var courseResultToCreate = new CourseResult();
            courseResultToCreate.CourseId = courseResultDto.CourseId;
            courseResultToCreate.StudentId = courseResultDto.StudentId;
            courseResultToCreate.UserId = courseResultDto.UserId;
            courseResultToCreate.Note = courseResultDto.Note;*/
            var courseResultToCreate = _mapper.Map<CourseResult>(courseResultDto);
            _repository.Add(courseResultToCreate);
            if (await _repository.SaveAll())
                return Ok(courseResultToCreate);
            return BadRequest();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) 
        {
            var courseResult = await _repository.GetCourseByUserIdAsync(id);

            var courseResultDto = new CourseResultListDto();


            if (courseResult == null)
                return NotFound("El usuario no tiene notas registradas");
            return Ok(courseResult);
        }

    }
}
