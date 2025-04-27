namespace HatPepper.Booking.App.Domain;

public interface IGourmetService
{
    Task<IReadOnlyList<Restaurant>> FindNearbyAsync(Location currentLocation);
}