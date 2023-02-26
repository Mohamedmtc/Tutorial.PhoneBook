using MediatR;
using Tutorial.PhoneBook.Core.Messages;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllV3Query :  BaseRequest, IRequest<UserGetAllV3Output>
    {
        public UserGetAllV3Query() { }
        public UserGetAllV3Query(Guid correlationId) : base(correlationId) { }

    }
}