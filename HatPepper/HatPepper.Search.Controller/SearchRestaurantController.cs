using HatPepper.Controller;
using HatPepper.Search.UseCase;
using HatPepper.Search.View;

namespace HatPepper.Search.Controller;

/// <summary>
/// 近隣の店舗を検索する。
/// </summary>
public class SearchRestaurantController(ISearchRestaurantUseCase useCase, ISearchRestaurantView view) 
    : ISearchRestaurantController
{
    /// <summary>
    /// 近隣の店舗を検索する。
    /// </summary>
    /// <returns></returns>
    public async Task<RestaurantId> SelectRestaurantAsync()
    {
        // 名称で店舗を検索する。
        var restaurants = await useCase.FindNearbyAsync().ToListAsync();

        // ViewModelに変換する。
        var viewModels = restaurants
            .Select((restaurant, index) => new RestaurantViewModel(index + 1, restaurant))
            .ToList();

        // 検索結果を表示する。
        view.Show(viewModels);

        // 店舗を選択する。
        return view.SelectRestaurant(viewModels).Restaurant.Id;
    }
}