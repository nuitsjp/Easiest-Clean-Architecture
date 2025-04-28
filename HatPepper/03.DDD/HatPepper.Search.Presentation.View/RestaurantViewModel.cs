using HatPepper.Domain;
using HatPepper.Search.Domain;

namespace HatPepper.Search.Presentation.View;

/// <summary>
/// レストラン情報を検索結果表示用にラップするViewModelです。
/// </summary>
public record RestaurantViewModel(int No, RestaurantId Id, string Genre, string Name)
{
    /// <summary>
    /// 一覧表示や選択肢表示用の文字列表現を返します。
    /// </summary>
    /// <returns>連番とレストラン名を組み合わせた文字列です。</returns>
    public override string ToString() => $"{No}.{Name}";
}