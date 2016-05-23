using Abp.Application.Services.Dto;

namespace MyABP.Dto
{
    public class UsersDto:IInputDto
    {
        public string Name { get; set; } 
    }
}