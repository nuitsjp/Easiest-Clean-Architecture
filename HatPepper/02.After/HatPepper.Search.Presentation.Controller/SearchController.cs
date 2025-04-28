using HatPepper.Search.Application;
using HatPepper.Search.Presentation.View;

namespace HatPepper.Search.Presentation.Controller;

/// <summary>
/// 近隣の店舗を検索する。
/// </summary>
public class SearchController(ISearchRestaurant searchRestaurant, ISearchRestaurantView view) 
{
    /// <summary>
    /// 近隣の店舗を検索する。
    /// </summary>
    /// <returns></returns>
    public async Task FindNearbyAsync()
    {
        // 近隣の店舗を検索する。
        var restaurants = searchRestaurant.FindNearbyAsync();

        // VewModelに変換する。
        var restaurantViewModels =
            await restaurants
                .Select((restaurant, index) => new RestaurantViewModel(index + 1, restaurant))
                .ToArrayAsync();

        // 検索結果を表示する。
        view.Show(restaurantViewModels);
    }
}