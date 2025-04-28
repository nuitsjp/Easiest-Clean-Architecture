using HatPepper.Domain;

namespace HatPepper.Search.Domain;

/// <summary>
/// レストランの基本情報を不変的に保持するレコードです。
/// </summary>
/// <param name="Id">一意のレストラン識別子です。</param>
/// <param name="Genre">レストランのジャンル情報です。</param>
/// <param name="Name">レストランの名称です。nullや空文字列であってはなりません。</param>
public record Restaurant(RestaurantId Id, Genre Genre, string Name);