using RepWork.Abstract;
using RepWork.RepositoryLayerExample.Entities;

namespace RepWork.RepositoryLayerExample.Abstract;

public interface IProductRepository
    : IRepository<Product>
{
}