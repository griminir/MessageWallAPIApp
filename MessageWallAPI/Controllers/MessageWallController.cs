﻿using MessageWallAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageWallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private ILogger<MessageWallController> _logger;

        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger;
        }

        // GET: api/<MessageWallController> 
        [HttpGet]
        public IEnumerable<string> Get(string message = "", int id = 0) //?message=test&id=24 how to do it with url params
        {
            var output = new List<string>()
            {
                "Hello world",
                "How are you?"
            };

            if (string.IsNullOrWhiteSpace(message) == false)
            {
                output.Add(message);
            }

            return output;
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel message) 
        {
            _logger.LogInformation("our message was {Message}", message.Message);
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}