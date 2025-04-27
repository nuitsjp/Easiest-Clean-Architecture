namespace HatPepper.Model.UseCase;

    /// <summary>
/// 近隣検索ユースケース
/// </summary>
public class FindNearbyUseCase(IGeoCoordinator geoCoordinator, IGourmetService gourmetService) 
        : IFindNearbyUseCase
{
    /// <summary>
    /// 現在地の近隣店舗を検索する。
    /// </summary>
    public async Task<IReadOnlyList<Restaurant>> FindNearbyAsync()
    {
        // 現在地を取得する。
        var location = geoCoordinator.GetCurrent();

        // 現在地から店舗を検索する。
        return await gourmetService.FindNearbyAsync(location);
    }
}