using Example1.Contracts;
using Example1.Entities;
using Example1.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Repository
{
    public class OwnerRepository : RepositoryBase<Owner> , IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
