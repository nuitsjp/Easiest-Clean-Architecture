namespace HatPepper.Reservation;

/// <summary>
/// Reservation ドメインのユースケースを定義する Port インターフェース
/// </summary>
public interface IReservationService
{
    IReadOnlyList<TimeSlot> GetAvailableTimeSlots(RestaurantId restaurantId, Date date, int partySize);

    ReservationStatus Reserve(RestaurantId restaurantId, TimeSlot timeSlot, int partySize);
}