namespace HatPepper.Reservation.UseCase;

public class ReservationUseCase(IReservationService reservationService) : IReservationUseCase
{
    public IReadOnlyList<TimeSlot> GetAvailableTimeSlots(RestaurantId restaurantId, Date date, int partySize)
        => reservationService.GetAvailableTimeSlots(restaurantId, date, partySize);

    public ReservationStatus Reserve(RestaurantId restaurantId, TimeSlot timeSlot, int partySize)
        => reservationService.Reserve(restaurantId, timeSlot, partySize);
}