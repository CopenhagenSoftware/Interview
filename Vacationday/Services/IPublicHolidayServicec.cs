using Interview.Models;

namespace Interview.Services
{
    public interface IPublicHolidayServicec
    {
        /// <summary>
        /// Get all public holidays
        /// </summary>
        /// <returns>A list of holidays</returns>
        Task<IEnumerable<PublicHolidaysEntity>> GetPublicHolidaysAsync();
    }
}
