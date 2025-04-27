namespace HatPepper.Model.UseCase;

public interface IGourmetService
{
    Task<IReadOnlyList<Restaurant>> FindNearbyAsync(Location currentLocation);
}