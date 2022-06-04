using Microsoft.AspNetCore.Mvc;
using StaffService.Services;

namespace StaffService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly ILogger<StaffController> _logger;
        private readonly IStaffRepository _staffRepository;

        public StaffController(
            ILogger<StaffController> logger,
            IStaffRepository staffRepository)
        {
            _logger = logger;
            _staffRepository = staffRepository;
        }

        [HttpGet("employees")]
        public IActionResult GetAllEmployees()
        {
            var employees = _staffRepository.GetAllEmployees();

            return Ok(employees);
        }

        [HttpGet("roberto")]
        public IActionResult GetRoberto()
        {
            var roberto = _staffRepository.LoadRoberto();

            return Ok(roberto);
        }
    }
}
