using System.Net.Http.Headers;
using HatPepper.Controller;

namespace HatPepper.Reservation.Controller;

public class ReservationController(IReservationService reservationService) : IReservationController
{
    public async Task ReserveAsync(RestaurantId restaurantId)
    {
        var timeSlots = 
            reservationService.GetAvailableTimeSlots(
                new AvailabilityRequest(
                    restaurantId,
                    Date.Today, 
                    1));


    }
}