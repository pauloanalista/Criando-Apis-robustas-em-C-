namespace XGame.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
