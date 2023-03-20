using Tutorial.PhoneBook.Core.Messages;
using Tutorial.ProjectManagement.Application.Business.User.Query;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.V2
{
    public class GetAllResponseV2 : BaseResponse
    {
        public GetAllResponseV2() { }
        public GetAllResponseV2(Guid correlationId) : base(correlationId) { }

        public List<SelectedUserDto> Result { get; set; }
    }
}
