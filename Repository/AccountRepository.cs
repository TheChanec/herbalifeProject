using Example1.Contracts;
using Example1.Entities;
using Example1.Entities.Models;

namespace Example1.Repository
{
    public class AccountRepository : RepositoryBase<Account> , IAccountRepository
    {
        public AccountRepository(RepositoryContext respositoryContext) : base(respositoryContext) { } 
    }
}
