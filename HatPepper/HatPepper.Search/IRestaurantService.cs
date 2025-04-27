namespace HatPepper.Search;

public interface IRestaurantService
{
    Task<IReadOnlyList<Restaurant>> SearchAsync(Location currentLocation);
}