namespace ShroomCity.Models;

using System.Text.Json.Serialization;

public class Envelope<T> where T : class
{
    public override string ToString() => $"PageSize: {this.PageSize}, PageNumber: {this.PageNumber}, TotalPages: {this.TotalPages}, Items: {this.Items}";
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int TotalPages { get; set; }
    [JsonPropertyName("data")]
    public IEnumerable<T> Items { get; set; } = null!;
}
