namespace TownBestiaryApi.Models.Reports; 

public class Report {
    public int Id { get; set; }
    public string Message { get; set; }
    public ReportType Type { get; set; }
    public DateTime Date { get; set; }
    public string Localization { get; set; }
}