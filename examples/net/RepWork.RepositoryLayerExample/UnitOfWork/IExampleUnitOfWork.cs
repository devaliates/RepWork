using RepWork.Abstract;
using RepWork.RepositoryLayerExample.Abstract;

namespace RepWork.RepositoryLayerExample.UnitOfWork;

public interface IExampleUnitOfWork
    : IUnitOfWork
{
    public IUserRepository UserRepository { get; }
    public IProductRepository ProductRepository { get; }
}