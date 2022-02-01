using RepWork.Abstract;
using RepWork.RepositoryLayerExample.Abstract;

namespace RepWork.ServiceLayerExample.UnitOfWork;

public interface IExampleUnitOfWork
    : IUnitOfWork
{
    public IUserRepository UserRepository { get; }
    public IProductRepository ProductRepository { get; }
}