namespace HatPepper.Controller;

public interface IBookingController
{
    Task ReserveAsync(RestaurantId restaurantId);
}