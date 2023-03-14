using Interview.Models;

namespace Interview.Services
{
    public class HolidayRegistrationService : IHolidayRegistrationService
    {
        public Task<IReadOnlyList<HolidayRegistrationEntity>> GetHolidayRegistartionsAsync()
        {
            var registrations = new List<HolidayRegistrationEntity> 
            {
                new HolidayRegistrationEntity() { FirstDay = new DateOnly(2023, 12, 1), LastDay = new DateOnly(2023,12,4) },
                new HolidayRegistrationEntity() { FirstDay = new DateOnly(2023, 12, 18), LastDay = new DateOnly(2023,12,31) },
            };

            return Task.FromResult<IReadOnlyList<HolidayRegistrationEntity>>(registrations);
        }
    }
}
