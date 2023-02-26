using Ardalis.ApiEndpoints;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tutorial.PhoneBook.Application.Business.User.Query;
using Tutorial.PhoneBook.Core.Messages;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User
{
    public class UserGetAllV3Response: BaseResponse
    {
        public UserGetAllV3Response() { }
        public UserGetAllV3Response(Guid correlationId) : base(correlationId) { }
        public List<SelectedUserV3Dto> Result { get; set; }
    }
}
