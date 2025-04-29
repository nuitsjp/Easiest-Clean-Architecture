using HatPepper.Domain;
using HatPepper.Reservation.Domain;

namespace HatPepper.Reservation.Gateway.HotPepper;

/// <summary>
/// HotPepper APIを利用したレストラン予約サービスの実装です。
/// 予約可能な時間帯の取得や予約処理を行います。
/// </summary>
/// <remarks>
/// このクラスはダミー実装であり、実際のAPI連携は行っていません。将来的な拡張や外部API連携のための土台となります。
/// </remarks>
public class ReservationService : IReservationService
{
    /// <summary>
    /// 指定したレストラン、日付、人数に対して予約可能な時間帯を非同期で取得します。
    /// ダミー実装として、<paramref name="date"/> の17時～20時の時間帯を返します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="date">予約希望日です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <remarks>
    /// 実際のAPI連携は未実装です。将来的には外部サービスから動的に時間帯を取得する想定です。
    /// </remarks>
    public async IAsyncEnumerable<TimeSlot> GetAvailableTimeSlotsAsync(RestaurantId restaurantId, Date date, int partySize)
    {
        // ダミー実装として、指定日の17時～20時の時間帯を返します。
        yield return (TimeSlot)date.AsPrimitive().AddHours(17);
        yield return (TimeSlot)date.AsPrimitive().AddHours(18);
        yield return (TimeSlot)date.AsPrimitive().AddHours(19);
        yield return (TimeSlot)date.AsPrimitive().AddHours(20);
        await Task.CompletedTask;
    }

    /// <summary>
    /// 指定したレストラン、時間帯、人数で予約を実行します。
    /// </summary>
    /// <param name="restaurantId">予約対象のレストランIDです。</param>
    /// <param name="timeSlot">予約する時間帯です。</param>
    /// <param name="partySize">予約人数です。</param>
    /// <remarks>
    /// ダミー実装のため、実際の予約処理は行われません。将来的なAPI連携を想定しています。
    /// </remarks>
    public Task ReserveAsync(RestaurantId restaurantId, TimeSlot timeSlot, int partySize)
    {
        // ダミー実装として、何も処理を行いません。
        return Task.CompletedTask;
    }
}