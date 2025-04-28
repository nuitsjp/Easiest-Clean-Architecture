using HatPepper.Controller;
using HatPepper.Reservation.Controller;
using HatPepper.Reservation.Gateway.HotPepper;
using HatPepper.Reservation.UseCase;
using HatPepper.Reservation.View;
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

SearchService.ApiKey = args[0];

var controller =
    new HatPepperController(
        new SearchController(
            new SearchRestaurantUseCase(
                new GeoCoordinator(),
                new SearchService()),
            new SearchRestaurantView()),
        new ReservationController(
            new ReservationUseCase(
                new ReservationService()),
            new ReservationView()
        ));
await controller.ReserveRestaurantAsync();