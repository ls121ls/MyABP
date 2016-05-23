using System.Collections.Generic;
using Abp.Application.Services;
using MyABP.Entities;

namespace MyABP.Dto
{
    public interface IUsersService : IApplicationService
    {
        List<USERS> GetAllUser();
    }
}