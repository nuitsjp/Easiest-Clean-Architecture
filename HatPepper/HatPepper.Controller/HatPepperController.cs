namespace HatPepper.Controller;

public class HatPepperController(
    ISearchRestaurantController searchRestaurantController,
    IBookingRestaurantController bookingRestaurantController)
{
    public async Task ReserveRestaurantAsync()
    {
        // 近隣の店舗を検索する。
        var restaurantId = await searchRestaurantController.SelectRestaurantAsync();

        // 店舗を予約する。
        await bookingRestaurantController.BookingRestaurantAsync(restaurantId);
    }
}