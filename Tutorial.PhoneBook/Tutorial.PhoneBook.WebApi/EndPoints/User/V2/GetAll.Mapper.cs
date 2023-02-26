using AutoMapper;
using Tutorial.PhoneBook.Application.Business.User.Query;
using Tutorial.PhoneBook.WebApi.EndPoints.User.v2;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.V2
{
    public class GetAllV2Mapper : Profile
    {
        public GetAllV2Mapper()
        {
            CreateMap<GetAllV2Request, UserGetAllV2Query>()
                .ConstructUsing(src => new UserGetAllV2Query());
            CreateMap<UserGetAllV2Output, GetAllV2Response>()
               .ConstructUsing(src => new GetAllV2Response());
        }

    }
}
