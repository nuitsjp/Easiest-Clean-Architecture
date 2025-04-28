namespace HatPepper.Generic.Presentation.Controller;

/// <summary>
/// 予約処理を担当するコントローラーのインターフェースです。
/// </summary>
public interface IReservationController
{
    /// <summary>
    /// 指定された店舗IDに対して予約処理を実行します。
    /// </summary>
    /// <param name="restaurantId">予約対象となる店舗の識別子です。</param>
    Task ReserveAsync(RestaurantId restaurantId);
}