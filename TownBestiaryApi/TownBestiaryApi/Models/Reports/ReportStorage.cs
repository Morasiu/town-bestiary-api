namespace TownBestiaryApi.Models.Reports; 

public class ReportStorage {
	public static List<Report> Reports { get; set; } = new() {
		new Report {
			Date = DateTime.Now.AddDays(-1),
			Type = ReportType.DangerousAnimal,
			Message = "Dzik!",
			Longitude = 50.0094m,
			Latitude = 19.9212m,
		}
	};
}