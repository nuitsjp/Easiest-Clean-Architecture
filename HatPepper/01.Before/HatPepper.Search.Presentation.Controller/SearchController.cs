using HatPepper.Search.Application;
using HatPepper.Search.Presentation.View;

namespace HatPepper.Search.Presentation.Controller;

/// <summary>
/// 近隣の店舗を検索する。
/// </summary>
public class SearchController
{
    /// <summary>
    /// 近隣の店舗を検索する。
    /// </summary>
    /// <returns></returns>
    public async Task FindNearbyAsync()
    {
        // 近隣の店舗を検索する。
        var searchRestaurant = new SearchRestaurant();
        var gourmetSearchResult = await searchRestaurant.FindNearbyAsync();

        // VewModelに変換する。
        var restaurantViewModels =
            gourmetSearchResult
                .Results
                .Shops
                .Select((shop, index) => new RestaurantViewModel(index + 1, shop));

        // 検索結果を表示する。
        var view = new SearchRestaurantView();
        view.Show(restaurantViewModels);
    }
}