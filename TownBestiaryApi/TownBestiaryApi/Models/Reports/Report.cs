using TownBestiaryApi.Models.Animals;

namespace TownBestiaryApi.Models.Reports; 

public class Report {
    public int Id { get; set; }
    public string Message { get; set; }
    public ReportType Type { get; set; }
    public DateTime Date { get; set; }
    public decimal Longitude { get; set; }
    public decimal Latitude { get; set; }
    public string TelephoneNumber { get; set; }
    public string Species { get; set; }

}
