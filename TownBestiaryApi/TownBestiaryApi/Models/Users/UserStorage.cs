using TownBestiaryApi.Models.Boards;
using TownBestiaryApi.Models.Reports;

namespace TownBestiaryApi.Models.Users;

public class UserStorage {
	public static User User { get; set; } = new User {
		Id = 1,
		UserName = "CrazyHedgehog77",
		Reports = new List<Report> {
			new Report {
				Id = 1,
				Date = DateTime.Now.AddDays(-7),
				Type = ReportType.InjuredAnimal,
				Longitude = 50.017554m,
				Latitude = 19.816262m,
				Message = "Ranna sarna leży w rowie przy drodze"
			},
			new Report {
				Id = 2,
				Date = DateTime.Now.AddDays(-20),
				Type = ReportType.DangerousAnimal,
				Longitude = 50.022185m,
				Latitude = 19.911567m,
				Message = "Stado dzików przy śmietniku"
			}
		},
		CollectedBoards = new List<Board>(BoardsStorage.Boards.Take(2)),
	};
}