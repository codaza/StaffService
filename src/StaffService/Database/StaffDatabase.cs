using StaffService.Database.Entities;

namespace StaffService.Database
{
    public static class StaffDatabase
    {
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Ivan", Salary = 1000 },
                new Employee { Id = 2, Name = "Boris", Salary = 500 },
                new Employee { Id = 3, Name = "Roberto", Salary = 10000 }
            };
        }
    }
}
