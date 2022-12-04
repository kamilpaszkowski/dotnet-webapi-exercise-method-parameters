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

        // ten endpoint jest gotowy
        // endpoint zawiera dodatkowe parametery które służą do filtrowania wyników
        // request będzie wygłądał tak: /api/trainings?name=webapi
        [HttpGet("")]
        public IActionResult GetTrainings([FromQuery] GetTrainingsListRequest request) => Ok(new TrainingsList());

        // ten endpoint jest gotowy
        // endpoint zawiera przykład jaki typ parameteru musi byc aby móć zrobić upload pliku
        [HttpPost("{id}/presentation")]
        public IActionResult UploadPresentation([FromRoute] int id, [FromForm] IFormFile presentationFile) => NoContent();

        // endpointy poniżej są do zrobienia
        // -----------------------------------------------------------------------------------------------------------------

        // request będzie wygłądał tak: /api/trainings/1/attendees?firstName=kamil
        [HttpGet("{id}/attendees")]
        public IActionResult GetTrainingAttendees([?] int id, [?] GetTrainingAttendeesRequest request) => Ok();

        // endpoint oczekuje przekazania danych na temat nowego treningu w obiekcie CreateTrainingRequest
        [HttpPost("")]
        public IActionResult CreateTraining([?] CreateTrainingRequest request) => NoContent();

        // endpoint oczekuje paramteru id jako cześć route
        [HttpDelete("{id}")]
        public IActionResult DeleteTraining([?] int id) => NoContent();

        // endpoint oczekuje parametru id jako część route oraz przekazania informacji potrzebnych do uaktualnienia treningu.
        [HttpPut("{id}")]
        public IActionResult UpdateTraining([?] int id, [?] UpdateTrainingRequest request) => NoContent();
    }
}
