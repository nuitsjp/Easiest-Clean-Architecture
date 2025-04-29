using HatPepper.Domain;
using HatPepper.Reservation.Domain;

namespace HatPepper.Reservation.Application;

/// <summary>
/// レストラン予約に関するユースケースを実装するクラスです。
/// アプリケーション層として、予約可能な時間帯の取得や予約処理の業務ロジックを提供します。
/// </summary>
/// <remarks>
/// インフラ層の <see cref="IReservationService"/> を利用して、ユースケースの実装を委譲しています。
/// </remarks>
public class ReserveRestaurant(IReservationService reservationService) : IReserveRestaurant
{
    /// <summary>
    /// 指定したレストラン、日付、人数に対して予約可能な時間帯を非同期で取得します。
    /// 取得結果は <paramref name="date"/> の営業想定時間帯を返します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="date">予約希望日です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <remarks>
    /// 実際の取得処理は <see cref="IReservationService.GetAvailableTimeSlotsAsync"/> に委譲されます。
    /// </remarks>
    public IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize)
        => reservationService.GetAvailableTimeSlotsAsync(restaurantId, date, partySize);

    /// <summary>
    /// 指定したレストラン、時間帯、人数で予約を実行します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="timeSlot">予約する時間帯です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <remarks>
    /// 実際の予約処理は <see cref="IReservationService.ReserveAsync"/> に委譲されます。
    /// </remarks>
    public Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize)
        => reservationService.ReserveAsync(restaurantId, timeSlot, partySize);
}