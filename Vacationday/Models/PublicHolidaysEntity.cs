namespace Interview.Models
{
    public record PublicHolidaysEntity
    {
        public required DateOnly Date { get; init; }

        public required string Name { get; init; }

        public required bool PaidDayOff { get; init; }
    }
}
