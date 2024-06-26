namespace Application.Models.UpdateDtos;

public class UserUpdateDto
{
    public string? Id { get; set; }
    
    public string? FirstName { get; set; }

    public string? LastName {get; set;}

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
    
    public string? City { get; set; }
    
    public string? Country { get; set; }
}