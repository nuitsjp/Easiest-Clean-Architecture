using UnitGenerator;

namespace HatPepper;

[UnitOf<DateTime>]
public partial struct Date
{
    public static Date Today => (Date)DateTime.Today;
}