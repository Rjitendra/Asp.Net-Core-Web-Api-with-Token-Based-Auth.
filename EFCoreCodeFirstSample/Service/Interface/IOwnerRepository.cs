

using Model.Entity;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        IEnumerable<Owner> GetAllOwners();
    }
}
