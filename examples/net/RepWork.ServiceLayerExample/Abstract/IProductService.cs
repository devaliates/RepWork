using RepWork.ServiceLayerExample.Dtos;

namespace RepWork.ServiceLayerExample.Abstract;

public interface IProductService
{
    public Task Add(AddProductDto dto);
}