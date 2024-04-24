using System.ComponentModel.DataAnnotations;
using WebApi.Models.Interfaces;

namespace WebApi.Models
{
    public class Location : ILocation
    {
        [Required] public string Id { get; set; }
        [Required] public string City { get; set; }
        [Required] public string State { get; set; }
        [Required] public string ZipCode { get; set; }
    }
}
