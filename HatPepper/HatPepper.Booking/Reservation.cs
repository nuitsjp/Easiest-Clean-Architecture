namespace HatPepper.Booking;

/// <summary>予約情報を表すエンティティ</summary>
public class Reservation
{
    public Guid Id { get; }
    public Guid RestaurantId { get; }
    public DateTime DateTimeSlot { get; }
    public int PartySize { get; }
    public ReservationStatus Status { get; private set; }
    // ...コンストラクタ＆振る舞いメソッド...
}