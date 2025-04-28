namespace HatPepper.Controller;

public interface IBookingRestaurantController
{
    Task BookingRestaurantAsync(RestaurantId restaurantId);
}