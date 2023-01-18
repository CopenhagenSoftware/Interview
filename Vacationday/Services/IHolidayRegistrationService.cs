using Interview.Models;

namespace Interview.Services
{
    public interface IHolidayRegistrationService
    {
        /// <summary>
        /// Return holiday registartions for a given employee
        /// </summary>
        /// <param name="employeeId">Employee id</param>
        /// <returns>A list of registrations</returns>
        Task<IReadOnlyList<HolidayRegistrationEntity>> GetHolidayRegistartionsAsync(string employeeId);
    }
}
