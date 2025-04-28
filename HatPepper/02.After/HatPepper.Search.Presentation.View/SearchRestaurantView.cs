using FluentTextTable;

namespace HatPepper.Search.Presentation.View;

/// <summary>
/// 店舗検索の結果表示および選択操作を提供するビュークラスです。
/// </summary>
public class SearchRestaurantView : ISearchRestaurantView
{
    /// <summary>
    /// レストランの検索結果一覧をテーブル形式で表示します。
    /// </summary>
    /// <param name="restaurants">表示対象のレストラン情報のコレクションです。</param>
    public void Show(IEnumerable<RestaurantViewModel> restaurants)
    {
        // 検索結果をテーブル状に表示します。ユーザーが視覚的に比較しやすいようにしています。
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
}
