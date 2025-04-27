using HatPepper.Booking.App.Controller;
using HatPepper.Booking.App.UseCase;
using HatPepper.Booking.App.View;
using HatPepper.Booking.Gateway.Device;
using HatPepper.Booking.Gateway.HotPepper;

if(args.Length == 0)
{
    Console.WriteLine("APIキーを指定してください。");
    return;
}

RestaurantService.ApiKey = args[0];

SearchRestaurantController controller = new SearchRestaurantController(
    new FindNearbyUseCase(
        new GeoCoordinator(), 
        new RestaurantService()),
    new FindNearbyView());
await controller.NearbyViewAsync();