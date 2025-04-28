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
    void Show(IEnumerable<Restaurant> restaurants);
}