using System;
using System.Collections.Generic;
using MarvelCharacters.Models;
using MarvelCharacters.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MarvelsCharacters.Api.Controllers.Base;
using MarvelCharacters.API.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Linq;
using MarvelsCharacters.Api.Mapper;

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
        public async Task<ActionResult<IEnumerable<Character>>> Get()
        {
            try 
            {
                var characters = await _characterService.GetAll();
                var viewModels = characters.Select(c => c.ToViewModel());
                return Ok(viewModels);
            }
            catch (Exception ex)
            {
                return InternalServerError(new ErrorViewModel { Code = StatusCodes.Status500InternalServerError, Message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> Get(int id)
        {
            try 
            {
                var character = await _characterService.Get(id);
                var viewModel = character.ToViewModel();
                return Ok(viewModel);
            }
            catch (KeyNotFoundException ex) 
            {
                return NotFound(new ErrorViewModel { Code = StatusCodes.Status404NotFound, Message = ex.Message });
            }
            catch (Exception ex) 
            {
                return InternalServerError(new ErrorViewModel { Code = StatusCodes.Status500InternalServerError, Message = ex.Message });
            }
        }

        [HttpGet("{id}/comics")]
        public async Task<ActionResult<Character>> GetComics(int id)
        {
            try
            {
                var comics = await _characterService.GetAllComics(id);
                var viewModels = comics.Select(c => c.ToViewModel());
                return Ok(viewModels);
            }
            catch (Exception ex)
            {
                return InternalServerError(new ErrorViewModel { Code = StatusCodes.Status500InternalServerError, Message = ex.Message });
            }
        }
    }
}
