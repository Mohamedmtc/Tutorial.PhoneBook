using Ardalis.ApiEndpoints;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tutorial.PhoneBook.Application.Business.User.Query;

namespace Tutorial.PhoneBook.WebApi.EndPoints.User.v2
{
    public class GetAllV2Response
    {
        public List<SelectedUserDto> Result { get; set; }
    }
}
