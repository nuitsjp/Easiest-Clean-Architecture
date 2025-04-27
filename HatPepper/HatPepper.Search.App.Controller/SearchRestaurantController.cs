using HatPepper.Search.App.UseCase;
using HatPepper.Search.App.View;

namespace HatPepper.Search.App.Controller;

/// <summary>
/// 近隣の店舗を検索する。
/// </summary>
public class SearchRestaurantController(IFindNearbyUseCase useCase, IFindNearbyView view) 
{
    /// <summary>
    /// 近隣の店舗を検索する。
    /// </summary>
    /// <returns></returns>
    public async Task NearbyViewAsync()
    {
        // 名称で店舗を検索する。
        var shops = await useCase.FindNearbyAsync();

        // 検索結果を表示する。
        view.Show(shops);
    }
}