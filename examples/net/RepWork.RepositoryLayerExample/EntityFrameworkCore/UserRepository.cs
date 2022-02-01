using Microsoft.EntityFrameworkCore;

using RepWork.Repository;
using RepWork.RepositoryLayerExample.Abstract;
using RepWork.RepositoryLayerExample.Entities;

namespace RepWork.RepositoryLayerExample.EntityFrameworkCore;

public class UserRepository
    : EfRepositoryBase<User>, IUserRepository
{
    public UserRepository(DbContext context) : base(context)
    {
    }
}