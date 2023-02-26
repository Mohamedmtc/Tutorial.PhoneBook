using Tutorial.PhoneBook.Core.Messages;

namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllV3Output : BaseResponse
    {
        public UserGetAllV3Output() { }
        public UserGetAllV3Output(Guid correlationId) : base(correlationId) { }
        public List<SelectedUserV3Dto> Result { get; set; }
    }

    public class SelectedUserV3Dto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}