
using Model.Contexts;
using Model.Entity;
using Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApiContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public IEnumerable<Owner> GetAllOwners()
        {
            return FindAll()
                .OrderBy(ow => ow.Name)
                .ToList();
        }
    }
}
