using Interview.Models;

namespace Interview.Services
{
    public interface IPublicHolidayService
    {
        /// <summary>
        /// Get all public holidays
        /// </summary>
        /// <returns>A list of holidays</returns>
        Task<IReadOnlyList<PublicHolidaysEntity>> GetPublicHolidaysAsync();
    }
}
