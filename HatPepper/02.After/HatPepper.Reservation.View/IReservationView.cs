namespace HatPepper.Reservation.View;

/// <summary>
/// レストラン予約フローにおけるユーザーインターフェース操作を抽象化するインターフェースです。
/// 予約人数の入力、時間帯の選択、予約完了通知など、ユーザーとの対話処理を定義します。
/// </summary>
public interface IReservationView
{
    /// <summary>
    /// 予約人数をユーザーから入力として受け取ります。
    /// </summary>
    /// <returns>ユーザーが入力した予約人数です。</returns>
    int InputPartySize();

    /// <summary>
    /// 予約可能な時間帯一覧からユーザーに選択させ、その結果を返します。
    /// </summary>
    /// <param name="timeSlots">選択肢となる予約可能な時間帯のリストです。</param>
    /// <returns>ユーザーが選択した時間帯です。</returns>
    TimeSlot SelectTimeSlot(IReadOnlyList<TimeSlot> timeSlots);

    /// <summary>
    /// 予約が正常に完了したことをユーザーに通知します。
    /// </summary>
    void NotifySuccess();
}