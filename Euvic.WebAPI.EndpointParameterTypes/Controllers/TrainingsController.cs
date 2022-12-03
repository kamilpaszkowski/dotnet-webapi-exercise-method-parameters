using Euvic.WebAPI.EndpointParameterTypes.Controllers.Requests;
using Euvic.WebAPI.EndpointParameterTypes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Euvic.WebAPI.EndpointParameterTypes.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        //
        // Wypełnij brakujące parametery zgodnie z wymaganiami w komentarzach
        //
        // ----------------------------------------------------------------------------------------------------------------

        // endpoint zawiera dodatkowe parametery które służą do filtrowania wyników
        // request będzie wygłądał tak: /api/trainings?name=webapi
        [HttpGet("")]
        public IActionResult GetTrainings([FromQuery] GetTrainingsListRequest request) => Ok(new TrainingsList());

        // endpoint zawiera przykład jaki typ parameteru musi byc aby móć zrobić upload pliku
        [HttpPost("{id}/presentation")]
        public IActionResult UploadPresentation([FromRoute] int id, [FromForm] IFormFile presentationFile) => NoContent();

        // endpoint oczekuje dodatkowych parametery które służą do filtrowania wyników. Zawarte one są w obiekcie GetTrainingAttendeesRequest
        // request będzie wygłądał tak: /api/trainings/1/attendees?firstName=kamil
        [HttpGet("{id}/attendees")]
        public IActionResult GetTrainingAttendees() => Ok();

        // endpoint oczekuje przekazania danych na temat nowego treningu w obiekcie CreateTrainingRequest
        [HttpPost("")]
        public IActionResult CreateTraining() => NoContent();

        // endpoint oczekuje paramteru id jako cześć route
        [HttpDelete("{id}")]
        public IActionResult DeleteTraining() => NoContent();

        // endpoint oczekuje parametru id jako część route oraz przekazania informacji potrzebnych do uaktualnienia treningu. Informacje zawarte sa w obiekcie UpdateTrainingRequest
        [HttpPut("{id}")]
        public IActionResult UpdateTraining() => NoContent();
    }
}
