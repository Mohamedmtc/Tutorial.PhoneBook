using MediatR;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllQuery: IRequest<UserGetAllOutput>
    {
    }
}