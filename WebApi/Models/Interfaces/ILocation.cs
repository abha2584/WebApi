namespace WebApi.Models.Interfaces
{
    public interface ILocation
    {
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
    }
}
