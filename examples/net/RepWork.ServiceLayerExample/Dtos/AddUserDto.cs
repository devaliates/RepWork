namespace RepWork.ServiceLayerExample.Dtos;

public class AddUserDto
{
    public string Username { get; set; }
    public string Password { get; set; }

    public AddUserDto()
    {
        this.Username = string.Empty;
        this.Password = string.Empty;
    }
}