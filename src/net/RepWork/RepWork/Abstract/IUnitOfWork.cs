namespace RepWork.Abstract;

public interface IUnitOfWork<TDbContext>
    : IDisposable
{
    public Task<IUnitOfWork<TDbContext>> BeginTransactionAsync();

    public Task<int> Save();
}