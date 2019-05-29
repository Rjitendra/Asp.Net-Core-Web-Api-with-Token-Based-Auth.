using EFCoreCodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
    }
    public interface IAccountRepository : IRepositoryBase<Account>
    {
    }
}
