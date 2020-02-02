using System;
using System.Collections.Generic;
using MarvelCharacters.Models;
using MarvelCharacters.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MarvelsCharacters.Api.Controllers
{
    [ApiController]
    [Route("characters")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Character>> Get()
        {
            try 
            {
                return Ok(_characterService.Get());
            }
            catch (Exception ex) 
            {
                return BadRequest(ex);
            }
        }
    }
}
