using Microsoft.EntityFrameworkCore;
using TeamHolidayCalendarBackend.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TeamHolidayCalendarBackend.Data
{
    public class LeavePlanDbContext : DbContext
    {
        public LeavePlanDbContext(DbContextOptions<LeavePlanDbContext> options)
            :base(options)
        {}

        public DbSet<LeavePlan> LeavePlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LeavePlan>().HasData(
                new LeavePlan
                {
                    Id = Guid.NewGuid(),
                    EmployeeName = "Aslam",
                    LeaveStartDate = new DateTime(2024, 5, 1),
                    LeaveEndDate = new DateTime(2024, 5, 10),
                    LeaveReason = "Sick"
                },
                new LeavePlan
                {
                    Id = Guid.NewGuid(),
                    EmployeeName =  "Babar",
                    LeaveStartDate = new DateTime(2024, 5, 3),
                    LeaveEndDate = new DateTime(2024, 5, 5),
                    LeaveReason = "Urgent Work"
                },
                new LeavePlan
                {
                    Id = Guid.NewGuid(),
                    EmployeeName = "Jameel",
                    LeaveStartDate = new DateTime(2024, 5, 1),
                    LeaveEndDate = new DateTime(2024, 5, 8),
                    LeaveReason = "Brother Marriage"
                },
                new LeavePlan
                {
                    Id = Guid.NewGuid(),
                    EmployeeName = "Azeem",
                    LeaveStartDate = new DateTime(2024, 5, 11),
                    LeaveEndDate = new DateTime(2024, 5, 11),
                    LeaveReason = "Doctor Appointment"
                },
                new LeavePlan
                {
                    Id = Guid.NewGuid(),
                    EmployeeName = "Rizwan",
                    LeaveStartDate = new DateTime(2024, 5, 13),
                    LeaveEndDate = new DateTime(2024, 5, 16),
                },
                new LeavePlan
                {
                    Id = Guid.NewGuid(),
                    EmployeeName = "Iftikhar",
                    LeaveStartDate = new DateTime(2024, 6, 3),
                    LeaveEndDate = new DateTime(2024, 6, 6),
                }
            );
        }
    }
}
