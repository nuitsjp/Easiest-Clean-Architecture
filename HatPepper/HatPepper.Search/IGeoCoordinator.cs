namespace HatPepper.Search;

public interface IGeoCoordinator
{
    Task<Location> GetCurrentAsync();
}