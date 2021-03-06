using TownBestiaryApi.Models.Boards;
using TownBestiaryApi.Models.Reports;

namespace TownBestiaryApi.Models.Users; 

public class User {
    public int Id { get; set; }
    public string UserName { get; set; }
    public List<Board> CollectedBoards { get; set; }
    public List<Report> Reports { get; set; }
}