using HatPepper.Search.Domain;

namespace HatPepper.Search.Application;

/// <summary>
/// 近隣検索ユースケース
/// </summary>
public interface ISearchRestaurantService
{
    /// <summary>
    /// 現在地の近隣店舗を検索する。
    /// </summary>
    IAsyncEnumerable<Restaurant> FindNearbyAsync();
}