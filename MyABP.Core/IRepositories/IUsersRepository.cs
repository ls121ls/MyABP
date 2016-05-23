using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using MyABP.Entities;

namespace MyABP.IRepositories
{
    public interface IUsersRepository : IRepository<USERS>
    {
        List<USERS> GetAdminUsers();
    }
}
