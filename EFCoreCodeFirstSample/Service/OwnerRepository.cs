
using Model.Contexts;
using Model.Entity;
using Service.Interface;

namespace Service
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApiContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
