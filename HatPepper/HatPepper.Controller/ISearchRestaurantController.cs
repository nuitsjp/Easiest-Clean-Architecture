namespace HatPepper.Controller;

public interface ISearchRestaurantController
{
    Task<RestaurantId> SelectRestaurantAsync();
}