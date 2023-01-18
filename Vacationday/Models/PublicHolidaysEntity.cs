namespace Interview.Models
{
    public class PublicHolidaysEntity
    {
        public DateOnly Date { get; set; }

        public string Name { get; set; } = "";

        public bool PaidDayOff { get; set; } = true;
    }
}
