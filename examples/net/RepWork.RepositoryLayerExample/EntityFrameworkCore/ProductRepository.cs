using Microsoft.EntityFrameworkCore;

using RepWork.Repository;
using RepWork.RepositoryLayerExample.Abstract;
using RepWork.RepositoryLayerExample.Entities;

namespace RepWork.RepositoryLayerExample.EntityFrameworkCore;

public class ProductRepository
    : EfRepositoryBase<Product>, IProductRepository
{
    public ProductRepository(DbContext context) : base(context)
    {
    }
}