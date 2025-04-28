namespace HatPepper.Reservation;

/// <summary>予約確定のためのパラメータ</summary>
public record ReservationRequest(
    RestaurantId RestaurantId,
    TimeSlot DateTimeSlot,
    int PartySize
);