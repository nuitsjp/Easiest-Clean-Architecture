namespace HatPepper.Reservation;

/// <summary>
/// レストランの予約に関するサービスのインターフェースです。
/// 予約可能な時間帯の取得や予約処理を提供します。
/// </summary>
public interface IReservationService
{
    /// <summary>
    /// 指定したレストラン、日付、人数に対して予約可能な時間帯を非同期で取得します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="date">予約希望日です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <returns>利用可能な時間帯のコレクションを非同期で返します。</returns>
    IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize);

    /// <summary>
    /// 指定したレストラン、時間帯、人数で予約を実行します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="timeSlot">予約する時間帯です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <remarks>
    /// 予約が完了しない場合は例外が発生する可能性があります。
    /// </remarks>
    Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize);
}