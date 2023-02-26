using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllV3Handler : IRequestHandler<UserGetAllV3Query, UserGetAllV3Output>
    {
        public async Task<UserGetAllV3Output> Handle(UserGetAllV3Query request, CancellationToken cancellationToken)
        {
            UserGetAllV3Output userGetAllV3Output=new UserGetAllV3Output(request.CorrelationId()); 
            userGetAllV3Output.Result=new List<SelectedUserV3Dto>();
            userGetAllV3Output.Result.Add(new SelectedUserV3Dto());
            userGetAllV3Output.Result.Add(new SelectedUserV3Dto());
            Task.CompletedTask.Wait();
            return userGetAllV3Output;
        }
    }
}
