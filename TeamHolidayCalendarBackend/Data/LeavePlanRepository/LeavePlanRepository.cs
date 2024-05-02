using Microsoft.EntityFrameworkCore;
using TeamHolidayCalendarBackend.Models;

namespace TeamHolidayCalendarBackend.Data.LeavePlanRepository
{
    public class LeavePlanRepository : ILeavePlanRepository
    {
        private readonly LeavePlanDbContext _context;
        public LeavePlanRepository(LeavePlanDbContext context)
        {
            _context = context;
        }
        public async Task<List<LeavePlan>> GetAsync()
        {
            List<LeavePlan> leavePlans = await _context.LeavePlans.ToListAsync();
            return leavePlans;
        }

        public async Task<LeavePlan?> GetAsync(Guid id)
        {
            LeavePlan? leavePlan = await _context.LeavePlans.FindAsync(id);
            return leavePlan;
        }
    }
}
