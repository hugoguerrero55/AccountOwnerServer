using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return FindAll().OrderBy(o => o.Name).ToList();
        }

        public Owner GetOwnerById(Guid IdOwner)
        {
            return FindByCondition(f => f.IdOwner == IdOwner).FirstOrDefault();
        }

        public Owner GetOwnerWithDetails(Guid IdOwner)
        {
            return FindByCondition(f => f.IdOwner == IdOwner)
                .Include(i => i.Accounts)
                .FirstOrDefault();
        }

        public void CreateOwner(Owner owner)
        {
            Create(owner);
        }

        public void UpdateOwner(Owner owner)
        {
            Update(owner);
        }

        public void DeleteOwner(Owner owner)
        {
            Delete(owner);
        }
    }
}
