namespace HatPepper.Controller;

public interface ISearchController
{
    Task<RestaurantId> SelectAsync();
}