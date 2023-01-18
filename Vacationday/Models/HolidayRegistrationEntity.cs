namespace Interview.Models
{
    public record HolidayRegistrationEntity
    {
        public DateOnly FirstDay { get; init; }

        public DateOnly LastDay { get; init; }
    }
}
