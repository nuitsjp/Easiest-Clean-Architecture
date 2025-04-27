using HatPepper.Search.App.Controller;
using HatPepper.Search.App.UseCase;
using HatPepper.Search.App.View;
using HatPepper.Search.Gateway.Device;
using HatPepper.Search.Gateway.HotPepper;

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