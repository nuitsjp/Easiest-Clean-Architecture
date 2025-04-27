namespace HatPepper.Search.App.Domain;

public interface IRestaurantService
{
    Task<IReadOnlyList<Restaurant>> SearchAsync(Location currentLocation);
}