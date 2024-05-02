using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamHolidayCalendarBackend.Data.LeavePlanRepository;
using TeamHolidayCalendarBackend.Models;

namespace TeamHolidayCalendarBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavePlanController : ControllerBase
    {
        private readonly ILeavePlanRepository _leavePlanRepository;
        public LeavePlanController(ILeavePlanRepository leavePlanRepository)
        {
            _leavePlanRepository = leavePlanRepository;
        }

        [HttpGet]
        public async Task<List<LeavePlan>> Get()
        {
            List<LeavePlan> leavePlans = await _leavePlanRepository.GetAsync();
            return leavePlans;
        }

        [HttpGet("{id}")]
        public async Task<LeavePlan?> Get(Guid id)
        {
            LeavePlan? leavePlan = await _leavePlanRepository.GetAsync(id);
            return leavePlan;
        }
    }
}
