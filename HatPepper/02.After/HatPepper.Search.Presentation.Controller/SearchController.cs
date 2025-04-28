using HatPepper.Search.Application;
using HatPepper.Search.Presentation.View;

namespace HatPepper.Search.Presentation.Controller;

/// <summary>
/// 近隣の店舗を検索する。
/// </summary>
public class SearchController(ISearchRestaurantService service, ISearchRestaurantView view) 
{
    /// <summary>
    /// 近隣の店舗を検索する。
    /// </summary>
    /// <returns></returns>
    public async Task SelectAsync()
    {
        // 近隣の店舗を検索する。
        var restaurants = await service.FindNearbyAsync().ToListAsync();

        // ViewModelに変換する。
        var viewModels = restaurants
            .Select((restaurant, index) => new RestaurantViewModel(index + 1, restaurant))
            .ToList();

        // 検索結果を表示する。
        view.Show(viewModels);
    }
}