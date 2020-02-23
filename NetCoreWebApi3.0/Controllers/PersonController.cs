using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi3._0.Business.Abstract;
using NetCoreWebApi3._0.Entity;

namespace NetCoreWebApi3._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }



        [HttpGet]
        public IActionResult Get()
        {

            var person = _personService.GetAll();

            return Ok(person);
        }

        [HttpGet("{Id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var person = _personService.GetById(id);
            if (person == null)
            {
                return BadRequest("Person is Null!!!!");
            }

            return Ok(person);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Person is Null!!!!");
            }

            _personService.Create(person);

            return CreatedAtRoute("Get",
                new { Id = person.Id }, person);

        }

        [HttpPut("{Id}")]
        public IActionResult Put(int id,[FromBody] Person person)
        {

            if (person == null)
            {
                return BadRequest("Person is Null!!!!");
            }

            Person entity = _personService.GetById(id);

            if (entity == null)
            {
                return NotFound("The Person record could not be found");
            }

            entity.Name = person.Name;
            entity.Gender = person.Gender;

            _personService.Update(entity);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Person person = _personService.GetById(id);

            if (person == null)
            {
                return NotFound("The Person record could not be found");
            }

            _personService.Delete(person);
            return NoContent();

        }


    }
}