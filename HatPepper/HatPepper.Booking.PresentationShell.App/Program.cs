
using HatPepper.Booking.App.Controller;
using HatPepper.Booking.App.UseCase;
using HatPepper.Booking.App.View;
using HatPepper.Booking.Gateway.Device;
using HatPepper.Booking.Gateway.HotPepper;

FindNearbyController controller = new FindNearbyController(
    new FindNearbyUseCase(
        new GeoCoordinator(), 
        new GourmetService()),
    new FindNearbyView());
await controller.RunAsync();