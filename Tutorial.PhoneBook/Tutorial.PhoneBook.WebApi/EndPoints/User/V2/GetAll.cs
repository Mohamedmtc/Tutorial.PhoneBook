using Ardalis.ApiEndpoints;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.v2
{
    public class GetAll : EndpointBaseSync.WithRequest<GetAllRequest>
    .WithActionResult<GetAllResponse>
    {
        [ApiVersion("2.0")]
        [HttpGet(GetAllRequest.Route)]
        [SwaggerOperation(
            Summary = "Get list of All Users",
            Description = "list of All Users",
            OperationId = "Users.GetAll",
            Tags = new[]{ "UsersEndpoint" })]
        public override ActionResult<GetAllResponse> Handle([FromQuery]GetAllRequest request)
        {
            return Ok();
        }
    }
}
