namespace HatPepper.Reservation;

/// <summary>
/// 
/// </summary>
/// <param name="RestaurantId"></param>
/// <param name="Date"></param>
/// <param name="PartySize"></param>
public record AvailabilityRequest(
    RestaurantId RestaurantId,
    Date Date,
    int PartySize
);