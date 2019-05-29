using EFCoreCodeFirstSample;
using EFCoreCodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
    }
}
