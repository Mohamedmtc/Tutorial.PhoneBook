using Ardalis.ApiEndpoints;
using AutoMapper;
using Azure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tutorial.PhoneBook.Application.Business.User.Query;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.v2
{
    public class GetAllV2EndPoint : EndpointBaseAsync.WithoutRequest
    .WithActionResult<GetAllV2Response>
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public GetAllV2EndPoint(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [ApiVersion("2.0")]
        [HttpGet(GetAllV2Request.Route)]
        [SwaggerOperation(
            Summary = "Get list of All Users",
            Description = "list of All Users",
            OperationId = "Users.GetAll",
            Tags = new[]{ "UsersEndpoint" })]


        public override async Task<ActionResult<GetAllV2Response>> HandleAsync(CancellationToken cancellationToken = default)
        {
            UserGetAllV2Query userGetAllV2Query = new UserGetAllV2Query();
            var output = await _mediator.Send(userGetAllV2Query, cancellationToken);

            return Ok(_mapper.Map<GetAllV2Response>(output));
        }
    }
}
