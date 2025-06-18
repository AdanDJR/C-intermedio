namespace BusRouteControl.Web.Models
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }
        public string DepartureTime { get; set; } = null!;
        public string ArrivalTime { get; set; } = null!;
    }
}
