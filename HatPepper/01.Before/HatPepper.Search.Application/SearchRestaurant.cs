using HatPepper.Search.Gateway.Device;
using HatPepper.Search.Gateway.HotPepper;

namespace HatPepper.Search.Application;

    /// <summary>
/// 近隣検索ユースケース
/// </summary>
public class SearchRestaurant
{
    /// <summary>
    /// 現在地の近隣店舗を検索する。
    /// </summary>
    public async Task<GourmetSearchResult> FindNearbyAsync()
    {
        // 現在地を取得する。
        var geoCoordinator = new GeoCoordinator();
        var location = await geoCoordinator.GetCurrentAsync();

        // 現在地から店舗を検索する。
        var restaurantRepository = new GourmetSearchApi();
        return await restaurantRepository.FindNearbyAsync(location);
    }
}