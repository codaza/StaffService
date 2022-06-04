using StaffService.Database.Entities;

namespace StaffService.Services
{
    public interface IStaffRepository
    {
        public IEnumerable<Employee> GetAllEmployees();

        public Employee LoadRoberto();
    }
}
