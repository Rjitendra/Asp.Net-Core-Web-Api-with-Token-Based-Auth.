using EFCoreCodeFirstSample.Models;
using Model.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApiContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
