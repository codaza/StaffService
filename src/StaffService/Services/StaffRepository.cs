using StaffService.Database;
using StaffService.Database.Entities;

namespace StaffService.Services
{
    public class StaffRepository : IStaffRepository
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            //throw new Exception("Some strange error here!");

            return StaffDatabase.GetAllEmployees();
        }

        public Employee LoadRoberto()
        {
            //throw new KeyNotFoundException("Roberto! Where are you??");

            return StaffDatabase.GetAllEmployees().First(e => e.Name == "Roberto");
        }
    }
}
