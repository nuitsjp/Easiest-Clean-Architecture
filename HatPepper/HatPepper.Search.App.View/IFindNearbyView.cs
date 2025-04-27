namespace HatPepper.Search.App.View;

/// <summary>
/// 店舗検索ビュー
/// </summary>
public interface IFindNearbyView
{
    /// <summary>
    /// 検索結果を表示する。
    /// </summary>
    /// <param name="restaurants"></param>
    void Show(IEnumerable<RestaurantViewModel> restaurants);


    /// <summary>
    /// レストランを選択する。
    /// </summary>
    /// <param name="restaurants"></param>
    RestaurantViewModel SelectRestaurant(IEnumerable<RestaurantViewModel> restaurants);
}