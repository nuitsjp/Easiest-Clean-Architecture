namespace HatPepper.Search.View;

/// <summary>
/// レストラン検索結果の表示および選択操作を行うビューのインターフェースです。
/// </summary>
public interface ISearchRestaurantView
{
    /// <summary>
    /// レストランの検索結果一覧を表示します。
    /// </summary>
    /// <param name="restaurants">表示対象のレストラン情報のコレクションです。</param>
    void Show(IEnumerable<RestaurantViewModel> restaurants);

    /// <summary>
    /// 検索結果からユーザーにレストランを選択させます。
    /// </summary>
    /// <param name="restaurants">選択肢となるレストラン情報のコレクションです。</param>
    /// <returns>ユーザーが選択したレストランのViewModelです。</returns>
    RestaurantViewModel SelectRestaurant(IEnumerable<RestaurantViewModel> restaurants);
}