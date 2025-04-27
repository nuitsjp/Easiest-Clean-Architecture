using HatPepper.Search.App.Domain;

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
    void Show(IEnumerable<Restaurant> restaurants);
}