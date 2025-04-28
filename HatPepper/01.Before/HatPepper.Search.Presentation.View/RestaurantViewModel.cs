namespace HatPepper.Search.Presentation.View;

/// <summary>
/// レストラン情報を検索結果表示用にラップするViewModelです。
/// </summary>
public record RestaurantViewModel(int No, string Genre, string Name);