namespace HatPepper.Reservation.View;

public interface IReservationView
{
    int InputPartySize();

    TimeSlot SelectTimeSlot(IReadOnlyList<TimeSlot> timeSlots);

    void NotifySuccess();
}