using Interview.Models;

namespace Interview.Services
{
    public interface IHolidayRegistrationService
    {
        /// <summary>
        /// Return holiday registrations for a given employee
        /// </summary>
        /// <returns>A list of registrations</returns>
        Task<IReadOnlyList<HolidayRegistrationEntity>> GetHolidayRegistrationsAsync();
    }
}
