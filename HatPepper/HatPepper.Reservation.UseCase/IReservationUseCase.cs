namespace HatPepper.Reservation.UseCase;

public interface IReservationUseCase
{
    IReadOnlyList<TimeSlot> GetAvailableTimeSlots(RestaurantId restaurantId, Date date, int partySize);

    Reservation Reserve(RestaurantId restaurantId, TimeSlot timeSlot, int partySize);
}