using Ardalis.ApiEndpoints;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tutorial.PhoneBook.Application.Business.User.Query;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User
{
    public class GetAllEndPoint : EndpointBaseSync.WithoutRequest
    .WithActionResult<GetAllResponse>
    {
        private readonly IMediator _mediator;

        public GetAllEndPoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ApiVersion("1.0")]
        [HttpGet(GetAllRequest.Route)]
        [SwaggerOperation(
            Summary = "Get list of All Users",
            Description = "list of All Users",
            OperationId = "Users.GetAll",
            Tags = new[]{ "UsersEndpoint" })]
        
        public override ActionResult<GetAllResponse> Handle()
        {
            UserGetAllQuery query = new UserGetAllQuery();
            _mediator.Send(query);
            return Ok();
        }
    }
}
