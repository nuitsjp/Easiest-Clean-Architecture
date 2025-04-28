namespace HatPepper.Controller;

public interface IReservationController
{
    Task ReserveAsync(RestaurantId restaurantId);
}