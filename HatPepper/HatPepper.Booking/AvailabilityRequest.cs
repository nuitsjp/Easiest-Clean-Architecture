namespace HatPepper.Booking;

public record AvailabilityRequest(
    RestaurantId RestaurantId,
    DateTime Date,
    int PartySize
);