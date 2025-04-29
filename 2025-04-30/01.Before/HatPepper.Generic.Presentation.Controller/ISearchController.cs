using HatPepper.Domain;

namespace HatPepper.Generic.Presentation.Controller;

/// <summary>
/// 店舗検索処理を担当するコントローラーのインターフェースです。
/// </summary>
public interface ISearchController
{
    /// <summary>
    /// ユーザーによる店舗選択操作を実行し、選択された店舗IDを取得します。
    /// </summary>
    /// <returns>ユーザーが選択した店舗の識別子です。</returns>
    Task<RestaurantId> SelectAsync();
}