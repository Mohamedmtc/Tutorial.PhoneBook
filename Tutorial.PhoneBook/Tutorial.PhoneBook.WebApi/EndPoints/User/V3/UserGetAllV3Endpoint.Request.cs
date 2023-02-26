using Tutorial.PhoneBook.Core.Messages;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User
{
    public class UserGetAllV3Request: BaseRequest
    {
        public const string Route = "/api/user/v{version:apiVersion}/GetAll";
        public UserGetAllV3Request() { }
        public UserGetAllV3Request(Guid correlationId) : base(correlationId) { }
    }
}