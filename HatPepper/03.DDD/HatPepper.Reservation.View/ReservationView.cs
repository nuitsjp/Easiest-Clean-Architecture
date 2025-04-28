using HatPepper.Reservation.Domain;
using Sharprompt;

namespace HatPepper.Reservation.View;

/// <summary>
/// レストラン予約フローにおけるユーザーインターフェース処理を実装するクラスです。
/// ユーザーからの人数入力や時間帯選択、予約完了通知などの具体的な対話処理を提供します。
/// </summary>
public class ReservationView : IReservationView
{
    /// <summary>
    /// 予約人数をユーザーから入力として受け取ります。
    /// </summary>
    /// <returns>ユーザーが入力した予約人数です。</returns>
    public int InputPartySize()
    {
        return Prompt.Input<int>("予約人数を入力してください。");
    }

    /// <summary>
    /// 予約可能な時間帯一覧からユーザーに選択させ、その結果を返します。
    /// </summary>
    /// <param name="timeSlots">選択肢となる予約可能な時間帯のリストです。</param>
    /// <returns>ユーザーが選択した時間帯です。</returns>
    public TimeSlot SelectTimeSlot(IReadOnlyList<TimeSlot> timeSlots)
    {
        const string format = "yyyy/MM/dd HH:mm:ss";

        var timeSlot = Prompt.Select(
            "予約可能な時間スロットを選択してください。",
            timeSlots.Select(ts => ts.ToString(format)));

        return TimeSlot.Parse(timeSlot, format);
    }

    /// <summary>
    /// 予約が正常に完了したことをユーザーに通知します。
    /// </summary>
    public void NotifySuccess()
    {
        Console.WriteLine("予約が完了しました。");
    }
}