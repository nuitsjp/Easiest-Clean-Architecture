using UnitGenerator;

namespace HatPepper.Reservation;

[UnitOf<DateTime>]
public partial struct TimeSlot
{
    public string ToString(string format)
    {
        return value.ToString(format);
    }

    public static TimeSlot Parse(string s, string format)
    {
        return (TimeSlot)DateTime.ParseExact(s, format, null);
    }
}