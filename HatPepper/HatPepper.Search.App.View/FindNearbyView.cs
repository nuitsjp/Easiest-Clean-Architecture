using FluentTextTable;
using HatPepper.Search.App.Domain;

namespace HatPepper.Search.App.View;

/// <summary>
/// 店舗検索ビュー
/// </summary>
public class FindNearbyView : IFindNearbyView
{
    /// <summary>
    /// 検索結果を表示する。
    /// </summary>
    /// <param name="restaurants"></param>
    public void Show(IEnumerable<Restaurant> restaurants)
    {
        // 検索結果をテーブル状に表示する。
        Build
            .TextTable<Restaurant>(builder =>
            {
                builder
                    .Borders.InsideHorizontal.AsDisable()
                    .Columns.Add(x => x.Genre).NameAs("ジャンル")
                    .Columns.Add(x => x.Name).NameAs("店名");
            })
            .WriteLine(restaurants);
    }
}
