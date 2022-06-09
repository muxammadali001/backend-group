using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TaxiDrivers.Entities;
public class Driver
{
    [Key]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public int Age { get; set; }   

    [ForeignKey(nameof(CarId))]
    public Car Car { get; set; }

    [JsonIgnore]
    public Guid CarId { get; set; }
}