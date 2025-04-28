using HatPepper.Domain;
using HatPepper.Reservation.Domain;

namespace HatPepper.Reservation.Application;

/// <summary>
/// レストラン予約に関するユースケースのインターフェースです。
/// 予約可能な時間帯の取得や予約処理の契約を定義します。
/// </summary>
public interface IReservationUseCase
{
    /// <summary>
    /// 指定したレストラン、日付、人数に対して予約可能な時間帯を非同期で取得します。
    /// 取得結果は <paramref name="date"/> の営業想定時間帯となります。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="date">予約希望日です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <remarks>
    /// 実装はインフラ層のサービスに委譲されることが想定されます。
    /// </remarks>
    IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize);

    /// <summary>
    /// 指定したレストラン、時間帯、人数で予約を実行します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="timeSlot">予約する時間帯です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <remarks>
    /// 実装はインフラ層のサービスに委譲されることが想定されます。
    /// </remarks>
    Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize);
}