using HatPepper.Search.Domain;

namespace HatPepper.Search.Presentation.View;

/// <summary>
/// レストラン情報を検索結果表示用にラップするViewModelです。
/// </summary>
/// <param name="No">一覧表示時の連番です。1から始まることを想定します。</param>
/// <param name="Restaurant">表示対象のレストラン情報です。</param>
public record RestaurantViewModel(int No, Restaurant Restaurant)
{
    /// <summary>
    /// レストランのジャンル情報を取得します。
    /// </summary>
    public Genre Genre => Restaurant.Genre;

    /// <summary>
    /// レストランの名称を取得します。
    /// </summary>
    public string Name => Restaurant.Name;

    /// <summary>
    /// 一覧表示や選択肢表示用の文字列表現を返します。
    /// </summary>
    /// <returns>連番とレストラン名を組み合わせた文字列です。</returns>
    public override string ToString() => $"{No}.{Restaurant.Name}";
}