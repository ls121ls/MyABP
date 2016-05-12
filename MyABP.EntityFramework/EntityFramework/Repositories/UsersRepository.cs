using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.EntityFramework;
using MyABP.Entities;
using MyABP.IRepositories;

namespace MyABP.EntityFramework.Repositories
{
    public class UsersRepository:MyABPRepositoryBase<USERS>,IUsersRepository
    {
        public UsersRepository(IDbContextProvider<MyABPDbContext> dbContextProvider) : base(dbContextProvider)
        {
            
        }

        public List<USERS> GetAdminUsers()
        {
            return Table.Where(d => d.USER_ID == "ls").ToList();
        } 
    }
}
