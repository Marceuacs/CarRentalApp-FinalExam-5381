namespace CarRental.Application.DTOs;

public class ClientDto
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTime DOB { get; set; }
    public string Address { get; set; } = default!;
    public string Nationality { get; set; } = default!;
    public DateTime RentalStartDate { get; set; }
    public DateTime RentalEndDate { get; set; }
    public int CarId { get; set; }
}
