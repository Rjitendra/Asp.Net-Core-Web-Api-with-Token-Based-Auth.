
using Model.Contexts;
using Model.Entity;
using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(ApiContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
