namespace HatPepper.Booking;

/// <summary>Reserve の引数をまとめた VO</summary>
public record ReservationRequest(
    Guid RestaurantId,
    DateTime DateTimeSlot,
    int PartySize
);