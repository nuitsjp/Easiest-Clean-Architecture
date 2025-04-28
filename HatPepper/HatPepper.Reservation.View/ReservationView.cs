using Sharprompt;

namespace HatPepper.Reservation.View;

public class ReservationView : IReservationView
{
    public int InputPartySize()
    {
        return Prompt.Input<int>("予約人数を入力してください。");
    }

    public TimeSlot SelectTimeSlot(IReadOnlyList<TimeSlot> timeSlots)
    {
        const string format = "yyyy/MM/dd HH:mm:ss";

        var timeSlot = Prompt.Select(
            "予約可能な時間スロットを選択してください。",
            timeSlots.Select(ts => ts.ToString(format)));

        return TimeSlot.Parse(timeSlot, format);
    }

    public void NotifySuccess()
    {
        Console.WriteLine("予約が完了しました。");
    }
}