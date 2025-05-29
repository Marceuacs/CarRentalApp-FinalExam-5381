namespace CarRental.Application.DTOs;

public class CarDto
{
    public string LicensePlate { get; set; } = default!;
    public string Model { get; set; } = default!;
    public string Manufacturer { get; set; } = default!;
    public int Year { get; set; }
}
