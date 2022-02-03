using RepWork.RepositoryLayerExample.Entities;
using RepWork.RepositoryLayerExample.UnitOfWork;
using RepWork.ServiceLayerExample.Abstract;
using RepWork.ServiceLayerExample.Dtos;

namespace RepWork.ServiceLayerExample;

public class ProductService
    : IProductService
{
    private readonly IExampleUnitOfWork exampleUnitOfWork;

    public ProductService(IExampleUnitOfWork exampleUnitOfWork)
    {
        this.exampleUnitOfWork = exampleUnitOfWork;
    }

    public async Task Add(AddProductDto dto)
    {
        await exampleUnitOfWork.BeginTransactionAsync();
        await exampleUnitOfWork.ProductRepository.Insert(new Product()
        {
            Name = dto.Name,
        });
        await exampleUnitOfWork.Save();
    }
}