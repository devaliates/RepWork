using RepWork.Abstract;

namespace RepWork.RepositoryLayerExample.Entities;

public class User
    : IEntity
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public virtual ICollection<UserProduct>? UserProducts { get; set; }

    public User()
    {
        this.Username = string.Empty;
        this.Password = string.Empty;
    }
}