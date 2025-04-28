using HatPepper.Search.UseCase;
using HatPepper.Search.View;

namespace HatPepper.Search.Controller;

/// <summary>
/// 近隣の店舗を検索する。
/// </summary>
public class SearchController(ISearchRestaurantUseCase useCase, ISearchRestaurantView view) 
{
    /// <summary>
    /// 近隣の店舗を検索する。
    /// </summary>
    /// <returns></returns>
    public async Task FindNearbyAsync()
    {
        // 名称で店舗を検索する。
        var restaurants = await useCase
            .FindNearbyAsync()
            .ToListAsync();

        // 検索結果を表示する。
        view.Show(restaurants);
    }
}