namespace RepWork.Abstract;

public interface IUnitOfWork
    : IDisposable
{
    public Task BeginTransactionAsync();

    public Task<int> Save();
}