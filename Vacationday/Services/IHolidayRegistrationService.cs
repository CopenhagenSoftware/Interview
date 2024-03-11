using Interview.Models;

namespace Interview.Services
{
    public interface IHolidayRegistrationService
    {
        /// <summary>
        /// Return holiday registartions for a given employee
        /// </summary>
        /// <returns>A list of registrations</returns>
        Task<IReadOnlyList<HolidayRegistrationEntity>> GetHolidayRegistartionsAsync();

        ///<summary>
        ///Add another holiday registration - a holiday registration can only be between 1 and 25 days long (inclusive)
        ///</summary>
        Task AddHolidayRegistration(DateOnly startDate, int days);
    }
}
