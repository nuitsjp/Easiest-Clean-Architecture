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

        var timeSlots = await reservationUseCase
            .GetAvailableTimeSlotsAsync(restaurantId, Date.Today, partySize)
            .ToListAsync();

        var timeSlot = reservationView.SelectTimeSlot(timeSlots);

        await reservationUseCase.ReserveAsync(restaurantId, timeSlot, partySize);
    }
}