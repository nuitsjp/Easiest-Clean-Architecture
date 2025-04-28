using FluentTextTable;
using Sharprompt;

namespace HatPepper.Search.View;

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

    /// <summary>
    /// 検索結果からユーザーにレストランを選択させます。
    /// </summary>
    /// <param name="restaurants">選択肢となるレストラン情報のコレクションです。</param>
    /// <returns>ユーザーが選択したレストランのViewModelです。</returns>
    public RestaurantViewModel SelectRestaurant(IEnumerable<RestaurantViewModel> restaurants)
    {
        // ユーザーにレストランの選択を促します。選択肢はToString()で表示されます。
        return Prompt.Select("レストランを選択してください。", restaurants);
    }
}
