namespace Interview.Models
{
    public record PublicHolidaysEntity
    {
        public DateOnly Date { get; init; }

        public string Name { get; init; }

        public bool PaidDayOff { get; init; }
    }
}
