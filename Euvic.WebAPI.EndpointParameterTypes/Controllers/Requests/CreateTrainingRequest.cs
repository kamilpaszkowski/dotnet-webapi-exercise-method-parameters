namespace Euvic.WebAPI.EndpointParameterTypes.Controllers.Requests
{
    public class CreateTrainingRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
    }
}
