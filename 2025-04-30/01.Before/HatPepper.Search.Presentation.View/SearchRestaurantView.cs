using FluentTextTable;
using HatPepper.Search.Gateway.HotPepper;

namespace HatPepper.Search.Presentation.View;

/// <summary>
/// 店舗検索の結果表示および選択操作を提供するビュークラスです。
/// </summary>
public class SearchRestaurantView
{
    /// <summary>
    /// レストランの検索結果一覧をテーブル形式で表示します。
    /// </summary>
    public void Show(IEnumerable<Shop> shops)
    {
        // Shopからインデックスを付与して、表示用のレコードに変換します。
        var restaurantViewModels =
            shops.Select((shop, index) => new RestaurantViewModel(index + 1, shop.Genre.Name, shop.Name));

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
            .WriteLine(restaurantViewModels);
    }
}
