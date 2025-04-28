namespace HatPepper.Reservation.Gateway.HotPepper;

public class ReservationService : IReservationService
{
    public IReadOnlyList<TimeSlot> GetAvailableTimeSlots(RestaurantId restaurantId, Date date, int partySize)
    {
        throw new NotImplementedException();
    }

    public Reservation Reserve(RestaurantId restaurantId, TimeSlot timeSlot, int partySize)
    {
        throw new NotImplementedException();
    }
}