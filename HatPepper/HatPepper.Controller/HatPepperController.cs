namespace HatPepper.Controller;

public class HatPepperController(
    ISearchController searchController,
    IReservationController reservationController)
{
    public async Task ReserveRestaurantAsync()
    {
        // 近隣の店舗を検索する。
        var restaurantId = await searchController.SelectAsync();

        // 店舗を予約する。
        await reservationController.ReserveAsync(restaurantId);
    }
}