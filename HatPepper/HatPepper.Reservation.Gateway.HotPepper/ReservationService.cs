namespace HatPepper.Reservation.Gateway.HotPepper;

public class ReservationService : IReservationService
{
    public IReadOnlyList<TimeSlot> GetAvailableTimeSlots(AvailabilityRequest request)
    {
        throw new NotImplementedException();
    }

    public Reservation Reserve(ReservationRequest request)
    {
        throw new NotImplementedException();
    }
}