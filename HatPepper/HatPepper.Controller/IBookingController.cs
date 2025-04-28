namespace HatPepper.Controller;

public interface IBookingController
{
    Task BookingAsync(RestaurantId restaurantId);
}