using EFCoreCodeFirstSample.Models;
using Model.Contexts;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
