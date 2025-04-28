namespace HatPepper.Reservation;

/// <summary>
/// Reservation ドメインのユースケースを定義する Port インターフェース
/// </summary>
public interface IReservationService
{
    /// <summary>
    /// 指定レストラン・指定日に予約可能な 1 時間スロットを取得する
    /// </summary>
    /// <param name="request">
    ///   RestaurantId: 店舗 ID  
    ///   Date:           取得対象の日付  
    ///   PartySize:      予約人数  
    /// </param>
    /// <returns>予約可能な開始日時の一覧</returns>
    IReadOnlyList<TimeSlot> GetAvailableTimeSlots(AvailabilityRequest request);

    /// <summary>
    /// 新しい Reservation を作成（予約を確定）する
    /// </summary>
    /// <param name="request">
    ///   RestaurantId:    店舗 ID  
    ///   DateTimeSlot:    予約開始日時  
    ///   PartySize:       予約人数  
    /// </param>
    /// <returns>作成された Reservation エンティティ</returns>
    Reservation Reserve(ReservationRequest request);
}

/// <summary>予約確定のためのパラメータ</summary>
public record ReservationRequest(
    RestaurantId RestaurantId,
    DateTime DateTimeSlot,
    int PartySize
);