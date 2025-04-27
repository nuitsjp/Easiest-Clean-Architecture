using FluentTextTable;
using Sharprompt;

namespace HatPepper.Search.View;

/// <summary>
/// 店舗検索ビュー
/// </summary>
public class FindNearbyView : IFindNearbyView
{
    /// <summary>
    /// 検索結果を表示する。
    /// </summary>
    /// <param name="restaurants"></param>
    public void Show(IEnumerable<RestaurantViewModel> restaurants)
    {
        // 検索結果をテーブル状に表示する。
        Build
            .TextTable<RestaurantViewModel>(builder =>
            {
                builder
                    .Borders.InsideHorizontal.AsDisable()
                    .Columns.Add(x => x.No).NameAs("No.").HorizontalAlignmentAs(HorizontalAlignment.Right)
                    .Columns.Add(x => x.Name).NameAs("店名")
                    .Columns.Add(x => x.Genre).NameAs("ジャンル");
            })
            .WriteLine(restaurants);
    }

    public RestaurantViewModel SelectRestaurant(IEnumerable<RestaurantViewModel> restaurants)
    {
        return Prompt.Select("レストランを選択してください。", restaurants);
    }
}
