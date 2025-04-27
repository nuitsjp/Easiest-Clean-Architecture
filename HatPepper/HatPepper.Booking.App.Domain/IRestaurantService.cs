namespace HatPepper.Booking.App.Domain;

public interface IRestaurantService
{
    Task<IReadOnlyList<Restaurant>> SearchAsync(Location currentLocation);
}