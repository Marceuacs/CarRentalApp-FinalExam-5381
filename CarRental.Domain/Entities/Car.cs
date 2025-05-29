namespace CarRental.Domain.Entities;

public class Car
{
    public int Id { get; set; }
    public string LicensePlate { get; set; } = default!;
    public string Model { get; set; } = default!;
    public string Manufacturer { get; set; } = default!;
    public int Year { get; set; }

    public ICollection<Client>? Clients { get; set; }
}
