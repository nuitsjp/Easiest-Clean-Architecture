namespace HatPepper.Search;

public interface ISearchService
{
    IAsyncEnumerable<Restaurant> SearchAsync(Location currentLocation);
}