namespace HatPepper.Controller;

public class HatPepperController(
    ISearchController searchController,
    IBookingController bookingController)
{
    public async Task ReserveRestaurantAsync()
    {
        // 近隣の店舗を検索する。
        var restaurantId = await searchController.SelectAsync();

        // 店舗を予約する。
        await bookingController.BookingAsync(restaurantId);
    }
}