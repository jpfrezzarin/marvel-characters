using System;
using System.Collections.Generic;
using MarvelCharacters.Models;
using MarvelCharacters.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MarvelsCharacters.Api.Controllers.Base;
using MarvelCharacters.API.Models;
using Microsoft.AspNetCore.Http;

namespace MarvelsCharacters.Api.Controllers
{
    [ApiController]
    [Route("characters")]
    public class CharacterController : MarvelCharactersController
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
                return InternalServerError(new Error { Code = StatusCodes.Status500InternalServerError, Message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            try 
            {
                return Ok(_characterService.Get(id));
            }
            catch (KeyNotFoundException ex) 
            {
                return NotFound(new Error { Code = StatusCodes.Status404NotFound, Message = ex.Message });
            }
            catch (Exception ex) 
            {
                return InternalServerError(new Error { Code = StatusCodes.Status500InternalServerError, Message = ex.Message });
            }
        }
    }
}
