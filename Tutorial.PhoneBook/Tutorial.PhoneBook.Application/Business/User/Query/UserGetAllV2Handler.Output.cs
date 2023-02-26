namespace Tutorial.PhoneBook.Application.Business.User.Query
{
    public class UserGetAllV2Output
    {
        public List<SelectedUserDto> Result { get; set; }
    }

    public class SelectedUserDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}