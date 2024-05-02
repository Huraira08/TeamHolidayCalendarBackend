using TeamHolidayCalendarBackend.Models;

namespace TeamHolidayCalendarBackend.Data.LeavePlanRepository
{
    public interface ILeavePlanRepository
    {
        public Task<List<LeavePlan>> GetAsync();
        public Task<LeavePlan?> GetAsync(Guid id);
    }
}
