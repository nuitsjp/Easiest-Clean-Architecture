namespace HatPepper.Reservation.Gateway.HotPepper;

public class ReservationService : IReservationService
{
    public async IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize)
    {
        // dateの17時～20時の時間帯を取得する
        yield return (TimeSlot)date.AsPrimitive().AddHours(17);
        yield return (TimeSlot)date.AsPrimitive().AddHours(18);
        yield return (TimeSlot)date.AsPrimitive().AddHours(19);
        yield return (TimeSlot)date.AsPrimitive().AddHours(20);
        await Task.CompletedTask;
    }

    public Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize)
    {
        return Task.CompletedTask;
    }
}