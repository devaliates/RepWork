namespace RepWork.UnitOfWork;

public abstract class EfUnitOfWorkBase
    : IUnitOfWork
{
    private DbContext context;
    private bool disposed;
    private IDbContextTransaction? transaction;

    public EfUnitOfWorkBase(DbContext context)
    {
        this.context = context;
        this.disposed = false;
    }

    public async Task BeginTransactionAsync()
    {
        this.transaction = await context.Database.BeginTransactionAsync();
    }

    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    public async Task<int> Save()
    {
        try
        {
            var i = await this.context.SaveChangesAsync();

            if (this.transaction != null)
                await this.transaction.CommitAsync();

            return await Task.FromResult(i);
        }
        catch (Exception)
        {
            await this.transaction?.RollbackAsync();
            throw;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                this.context.Dispose();
            }
        }
        this.disposed = true;
    }
}