using RepWork.ServiceLayerExample.Dtos;

namespace RepWork.ServiceLayerExample.Abstract;

public interface IUserService
{
    public Task Add(AddUserDto dto);
}