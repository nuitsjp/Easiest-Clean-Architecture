namespace HatPepper.Booking;

public interface IBookingRestaurantService
{
    /// <summary>
    /// 指定レストラン・指定日に予約可能な１時間スロットを取得する
    /// </summary>
    /// <param name="request">
    ///   RestaurantId: 店舗ID  
    ///   Date:           取得したい日付  
    ///   PartySize:      予約人数  
    /// </param>
    /// <returns>開始時刻リスト (各要素はその時間帯の開始 DateTime)</returns>
    IReadOnlyList<DateTime> GetAvailableTimeSlots(AvailabilityRequest request);

    /// <summary>
    /// 予約を確定する
    /// </summary>
    /// <param name="request">
    ///   RestaurantId:  店舗ID  
    ///   DateTimeSlot:  予約開始日時 (GetAvailableTimeSlots のいずれか)  
    ///   PartySize:     予約人数  
    /// </param>
    /// <returns>作成された Reservation エンティティ</returns>
    Reservation Reserve(ReservationRequest request);
}