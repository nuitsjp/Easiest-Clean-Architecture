namespace HatPepper.Search;

public interface ISearchRestaurantService
{
    IAsyncEnumerable<Restaurant> SearchAsync(Location currentLocation);
}