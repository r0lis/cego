﻿using cego.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cego.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private List<Contact> contacts = new List<Contact> {
        new Contact{Id=1, FirstName="Pepek",LastName="Parker",NickName="debzot",Place="London"},
        new Contact{Id=2, FirstName="František",LastName="Novak",NickName="lopata", Place="Praha"}

        };
        // GET: api/<ContactController>
        [HttpGet]
        public ActionResult <IEnumerable<Contact>> Get()
        {
            return contacts;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            Contact contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact == null) {
                return NotFound(new {Message="Contact has not been foud." });
            }
            return Ok (contact) ;
        }

        // POST api/<ContactController>
        [HttpPost]
        public ActionResult<IEnumerable<Contact>>Post(Contact newContact)
        {
           contacts.Add(newContact);
            return contacts;
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
