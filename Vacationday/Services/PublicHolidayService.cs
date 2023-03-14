using Interview.Models;

namespace Interview.Services
{
    public class PublicHolidayService : IPublicHolidayService
    {
        public Task<IReadOnlyList<PublicHolidaysEntity>> GetPublicHolidaysAsync()
        {
            var holidays = new List<PublicHolidaysEntity> 
            {
                new PublicHolidaysEntity() { Date = new DateOnly(2023, 12, 23), Name = "Lille juleaften", PaidDayOff = false },
                new PublicHolidaysEntity() { Date = new DateOnly(2023, 12, 24), Name = "Juleaften", PaidDayOff = true },
                new PublicHolidaysEntity() { Date = new DateOnly(2023, 12, 25), Name = "2. Juledag", PaidDayOff = true },
            };

            return Task.FromResult<IReadOnlyList<PublicHolidaysEntity>>(holidays);
        }
    }
}
