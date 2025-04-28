using HatPepper.Search.Domain;

namespace HatPepper.Search.UseCase;

    /// <summary>
/// 近隣検索ユースケース
/// </summary>
public class SearchRestaurantUseCase(IGeoCoordinator geoCoordinator, ISearchService searchService) 
        : ISearchRestaurantUseCase
{
    /// <summary>
    /// 現在地の近隣店舗を検索する。
    /// </summary>
    public async IAsyncEnumerable<Restaurant> FindNearbyAsync()
    {
        // 現在地を取得する。
        var location = await geoCoordinator.GetCurrentAsync();

        // 現在地から店舗を検索する。
        await foreach (var restaurant in searchService.SearchAsync(location))
        {
            yield return restaurant;
        }
    }
}