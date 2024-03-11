using Interview.Models;

namespace Interview.Services
{
    public class HolidayRegistrationService : IHolidayRegistrationService
    {
        private static List<HolidayRegistrationEntity> _holidayRegistrations =
            new()
            {
                new HolidayRegistrationEntity()
                {
                    FirstDay = new DateOnly(2023, 12, 1),
                    LastDay = new DateOnly(2023,12,4)
                },
                new HolidayRegistrationEntity()
                {
                    FirstDay = new DateOnly(2023, 12, 18),
                    LastDay = new DateOnly(2023,12,31)
                }
            };

        public Task<IReadOnlyList<HolidayRegistrationEntity>> GetHolidayRegistartionsAsync()
        {
            return Task.FromResult<IReadOnlyList<HolidayRegistrationEntity>>(_holidayRegistrations);
        }

        public Task AddHolidayRegistration(DateOnly startDate, int days)
        {
            if (days < 1)
                throw new ArgumentException("A holiday registration must be at least 1 day long");
            if (days > 25)
                throw new ArgumentException("A single holiday registration may not exceed 25 days");

            var entity =
                new HolidayRegistrationEntity
                {
                    FirstDay = startDate,
                    LastDay = startDate.AddDays(days)
                };
            _holidayRegistrations.Add(entity);

            return Task.CompletedTask;
        }
    }
}
