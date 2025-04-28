namespace HatPepper.Reservation.UseCase;

public interface IReservationUseCase
{
    IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize);

    Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize);
}