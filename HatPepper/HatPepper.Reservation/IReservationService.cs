namespace HatPepper.Reservation;

/// <summary>
/// Reservation ドメインのユースケースを定義する Port インターフェース
/// </summary>
public interface IReservationService
{
    IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize);

    Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize);
}