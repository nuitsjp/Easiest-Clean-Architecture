using HatPepper.Booking.Controller;
using HatPepper.Controller;
using HatPepper.Search.Controller;
using HatPepper.Search.Gateway.Device;
using HatPepper.Search.Gateway.HotPepper;
using HatPepper.Search.UseCase;
using HatPepper.Search.View;

if (args.Length == 0)
{
    Console.WriteLine("APIキーを指定してください。");
    return;
}

SearchRestaurantService.ApiKey = args[0];

var controller =
    new HatPepperController(
        new SearchRestaurantController(
            new SearchRestaurantUseCase(
                new GeoCoordinator(),
                new SearchRestaurantService()),
            new SearchRestaurantView()),
        new BookingRestaurantController());
await controller.ReserveRestaurantAsync();