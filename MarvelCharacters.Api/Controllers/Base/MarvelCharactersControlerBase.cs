using MarvelsCharacters.Api.Util.ObjectResults;
using Microsoft.AspNetCore.Mvc;

namespace MarvelsCharacters.Api.Controllers.Base
{
    public class MarvelCharactersController : ControllerBase
    {
        protected InternalServerErrorObjectResult InternalServerError()
        {
            return new InternalServerErrorObjectResult();
        }

        protected InternalServerErrorObjectResult InternalServerError(object value)
        {
            return new InternalServerErrorObjectResult(value);
        }
    }
}