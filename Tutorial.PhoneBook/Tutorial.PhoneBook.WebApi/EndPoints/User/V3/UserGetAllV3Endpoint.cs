using Ardalis.ApiEndpoints;
using AutoMapper;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tutorial.PhoneBook.Application.Business.User.Query;
using Tutorial.PhoneBook.WebApi.EndPoints.User.v2;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.V3
{
    public class UserGetAllV3Endpoint : EndpointBaseAsync.WithRequest<UserGetAllV3Request>
    .WithActionResult<UserGetAllV3Response>
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public UserGetAllV3Endpoint(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [ApiVersion("3.0")]
        [HttpGet(UserGetAllV3Request.Route)]
        [SwaggerOperation(
            Summary = "Get list of All Users",
            Description = "list of All Users",
            OperationId = "Users.GetAll",
            Tags = new[] { "UsersEndpoint" })]


        public override async Task<ActionResult<UserGetAllV3Response>> HandleAsync([FromQuery]UserGetAllV3Request request, CancellationToken cancellationToken = default)
        {
            UserGetAllV3Query userGetAllV2Query = new UserGetAllV3Query(request.CorrelationId());
            var output = await _mediator.Send(userGetAllV2Query, cancellationToken);
            return Ok(_mapper.Map<UserGetAllV3Response>(output));
        }
    }
}
