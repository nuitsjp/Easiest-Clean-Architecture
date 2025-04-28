using System.Net.Http.Headers;
using HatPepper.Controller;
using HatPepper.Reservation.UseCase;
using HatPepper.Reservation.View;

namespace HatPepper.Reservation.Controller;

public class ReservationController(
    IReservationUseCase reservationUseCase,
    IReservationView reservationView) : IReservationController
{
    public async Task ReserveAsync(RestaurantId restaurantId)
    {
        var partySize = reservationView.InputPartySize();

        var timeSlots =
            reservationUseCase.GetAvailableTimeSlots(restaurantId, Date.Today, partySize);

        var timeSlot = reservationView.SelectTimeSlot(timeSlots);

        reservationUseCase.Reserve(restaurantId, timeSlot, partySize);
    }
}