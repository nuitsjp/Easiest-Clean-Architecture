namespace HatPepper.Search.Domain;

/// <summary>
/// レストラン検索サービスのインターフェースです。
/// </summary>
public interface IRestaurantRepository
{
    /// <summary>
    /// 近隣のレストランを非同期で検索します。
    /// </summary>
    /// <param name="currentLocation">検索の基準となる現在地の座標情報です。</param>
    /// <returns>検索結果のレストラン情報を非同期列挙として返します。</returns>
    IAsyncEnumerable<Restaurant> FindNearbyAsync(Location currentLocation);
}