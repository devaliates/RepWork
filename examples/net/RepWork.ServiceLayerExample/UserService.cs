using RepWork.RepositoryLayerExample.Entities;
using RepWork.RepositoryLayerExample.UnitOfWork;
using RepWork.ServiceLayerExample.Abstract;
using RepWork.ServiceLayerExample.Dtos;

namespace RepWork.ServiceLayerExample;

public class UserService
    : IUserService
{
    private readonly IExampleUnitOfWork exampleUnitOfWork;

    public UserService(IExampleUnitOfWork exampleUnitOfWork)
    {
        this.exampleUnitOfWork = exampleUnitOfWork;
    }

    public async Task Add(AddUserDto dto)
    {
        await this.exampleUnitOfWork.BeginTransactionAsync();
        await this.exampleUnitOfWork.UserRepository.Insert(new User()
        {
            Username = dto.Username,
            Password = dto.Password,
        });
        await this.exampleUnitOfWork.Save();
    }
}