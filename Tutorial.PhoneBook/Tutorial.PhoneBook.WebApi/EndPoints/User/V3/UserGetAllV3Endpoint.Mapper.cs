using AutoMapper;
using Tutorial.PhoneBook.Application.Business.User.Query;
using Tutorial.PhoneBook.WebApi.EndPoints.User.v2;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.V2
{
    public class GetAllV3Mapper : Profile
    {
        public GetAllV3Mapper()
        {
            CreateMap<UserGetAllV3Request, UserGetAllV3Query>()
                .ConstructUsing(src => new UserGetAllV3Query());
            CreateMap<UserGetAllV3Output, UserGetAllV3Response>()
               .ConstructUsing(src => new UserGetAllV3Response());
        }

    }
}
