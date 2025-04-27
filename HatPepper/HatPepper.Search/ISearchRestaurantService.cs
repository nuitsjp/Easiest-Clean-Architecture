namespace HatPepper.Search;

public interface ISearchRestaurantService
{
    Task<IReadOnlyList<Restaurant>> SearchAsync(Location currentLocation);
}