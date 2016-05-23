using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using MyABP.Entities;
using MyABP.IRepositories;

namespace MyABP.Dto
{
    public class UsersService: MyABPAppServiceBase, IUsersService
    {
        private readonly IUsersRepository _useRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _useRepository = usersRepository;
        } 
        public List<USERS> GetAllUser()
        {
            return _useRepository.GetAllList();
        }

        public void Create(USERS users)
        {
            _useRepository.Insert(users);
        }
    }
}
