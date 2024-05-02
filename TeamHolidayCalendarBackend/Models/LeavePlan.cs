namespace TeamHolidayCalendarBackend.Models
{
    public class LeavePlan
    {
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public string? LeaveReason { get; set; }
    }
}
