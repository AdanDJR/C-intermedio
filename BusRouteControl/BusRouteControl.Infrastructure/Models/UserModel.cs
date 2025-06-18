namespace BusRouteControl.Infrastructure.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public List<TicketModel> Tickets { get; set; } = new();
    }
}
