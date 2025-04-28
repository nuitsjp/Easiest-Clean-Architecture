namespace HatPepper.Search.UseCase;

    /// <summary>
/// 近隣検索ユースケース
/// </summary>
public class SearchRestaurantUseCase(IGeoCoordinator geoCoordinator, ISearchRestaurantService searchRestaurantService) 
        : ISearchRestaurantUseCase
{
    /// <summary>
    /// 現在地の近隣店舗を検索する。
    /// </summary>
    public IAsyncEnumerable<Restaurant> FindNearbyAsync()
    {
        // 現在地を取得する。
        var location = geoCoordinator.GetCurrent();

        // 現在地から店舗を検索する。
        return searchRestaurantService.SearchAsync(location);
    }
}