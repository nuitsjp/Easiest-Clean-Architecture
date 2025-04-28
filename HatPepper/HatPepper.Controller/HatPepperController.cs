namespace HatPepper.Controller;

/// <summary>
/// 検索および予約機能を統合的に提供するコントローラーです。
/// </summary>
public class HatPepperController(
    ISearchController searchController,
    IReservationController reservationController)
{
    /// <summary>
    /// 近隣の店舗を検索し、選択された店舗の予約処理を実行します。
    /// </summary>
    /// <remarks>
    /// ユーザーが店舗を選択した後、その店舗の予約を行うための処理をまとめて実行します。
    /// </remarks>
    public async Task ReserveRestaurantAsync()
    {
        // ユーザーが選択した店舗IDを取得し、予約処理に利用します。
        var restaurantId = await searchController.SelectAsync();

        // 選択された店舗の予約を実行します。
        await reservationController.ReserveAsync(restaurantId);
    }
}