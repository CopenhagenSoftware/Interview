namespace Interview.Models
{
    public record HolidayRegistrationEntity
    {
        public required DateOnly FirstDay { get; init; }

        public required DateOnly LastDay { get; init; }
    }
}
