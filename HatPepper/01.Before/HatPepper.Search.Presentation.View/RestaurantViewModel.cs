using HatPepper.Search.Gateway.HotPepper;

namespace HatPepper.Search.Presentation.View;

/// <summary>
/// レストラン情報を検索結果表示用にラップするViewModelです。
/// </summary>
public record RestaurantViewModel(int No, Shop Shop)
{
    /// <summary>
    /// 店舗のジャンル
    /// </summary>
    public string Genre => Shop.Genre.Name;

    /// <summary>
    /// 店舗の名称
    /// </summary>
    public string Name => Shop.Name;
}