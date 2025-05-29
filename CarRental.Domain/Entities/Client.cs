using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.Entities;

public class Client
{
    public int Id { get; set; }

    [Required, MaxLength(200)]
    public string FirstName { get; set; } = default!;

    [Required, MaxLength(400)]
    public string LastName { get; set; } = default!;

    [Required]
    public DateTime DOB { get; set; }

    [Required, MaxLength(500)]
    public string Address { get; set; } = default!;

    [Required]
    public string Nationality { get; set; } = default!;

    [Required]
    public DateTime RentalStartDate { get; set; }

    [Required]
    public DateTime RentalEndDate { get; set; }

    public int CarId { get; set; }
    public Car? Car { get; set; }
}
