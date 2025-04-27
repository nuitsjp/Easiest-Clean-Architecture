namespace HatPepper.Model.UseCase;

/// <summary>
/// 近隣検索ユースケース
/// </summary>
public interface IFindNearbyUseCase
{
    /// <summary>
    /// 現在地の近隣店舗を検索する。
    /// </summary>
    Task<IReadOnlyList<Restaurant>> FindNearbyAsync();
}