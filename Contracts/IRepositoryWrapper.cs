namespace Example1.Contracts
{
    public interface IRepositoryWrapper
    {
        IAccountRepository Account { get; }
        IOwnerRepository Owner { get; }

    }
}
