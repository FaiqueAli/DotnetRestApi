using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using testreactapp.Data;
using testreactapp.Model;

namespace testreactapp.Controllers 
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PersonController:ControllerBase
    {
        private readonly IPerson _repository;

        public PersonController(IPerson repository)
        {
            _repository=repository;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Person>> GET()
        {
            var _person= _repository.GetPersons();
             return Ok(_person);
        }
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonBeID(int id)
        {
            var person=_repository.GetPersonByID(id);
            if(person!=null)
                {return person;}
            return NotFound();
        }
        [HttpPost]
        public void  CreatePerson(Person P)
        {
            if(P!=null)
                {
                    _repository.CreatePerson(P);
                }
        }

    }
}