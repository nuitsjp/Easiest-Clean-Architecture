namespace HatPepper.Reservation.UseCase;

public class ReservationUseCase(IReservationService reservationService) : IReservationUseCase
{
    public IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize)
        => reservationService.GetAvailableTimeSlotsAsync(restaurantId, date, partySize);

    public Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize)
        => reservationService.ReserveAsync(restaurantId, timeSlot, partySize);
}