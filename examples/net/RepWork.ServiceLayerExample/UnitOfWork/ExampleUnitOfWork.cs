using RepWork.RepositoryLayerExample.Abstract;
using RepWork.RepositoryLayerExample.EntityFrameworkCore;
using RepWork.UnitOfWork;

namespace RepWork.ServiceLayerExample.UnitOfWork;

public class ExampleUnitOfWork
    : EfUnitOfWorkBase, IExampleUnitOfWork
{
    public IUserRepository UserRepository
    {
        get
        {
            if (userRepository == null)
                userRepository = new UserRepository(this.context);
            return userRepository;
        }
    }

    public IProductRepository ProductRepository
    {
        get
        {
            if (productRepository == null)
                productRepository = new ProductRepository(this.context);
            return productRepository;
        }
    }

    private readonly ExampleDbContext context;

    private IUserRepository? userRepository;

    private IProductRepository? productRepository;

    public ExampleUnitOfWork(ExampleDbContext context) : base(context)
    {
        this.context = context;
    }
}