using RepWork.Abstract;

namespace RepWork.RepositoryLayerExample.Entities;

public class Product
    : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<UserProduct>? UserProducts { get; set; }

    public Product()
    {
        this.Name = string.Empty;
    }
}