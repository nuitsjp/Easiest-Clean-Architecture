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

GourmetService.ApiKey = args[0];

FindNearbyController controller = new FindNearbyController(
    new FindNearbyUseCase(
        new GeoCoordinator(), 
        new GourmetService()),
    new FindNearbyView());
await controller.RunAsync();