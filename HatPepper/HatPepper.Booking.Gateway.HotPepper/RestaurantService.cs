using System.Text.Json;
using HatPepper.Booking.App.Domain;

namespace HatPepper.Booking.Gateway.HotPepper;

/// <summary>
/// グルメサーチAPIクライアント
/// </summary>
public class RestaurantService : IRestaurantService
{
    /// <summary>
    /// APIのエンドポイント
    /// </summary>
    private const string Endpoint = "http://webservice.recruit.co.jp/hotpepper/gourmet/v1/";

    /// <summary>
    /// HTTPクライアント
    /// </summary>
    private static HttpClient HttpClient { get; } = new();

    /// <summary>
    /// APIキー
    /// </summary>
    public static string ApiKey { get; set; } = string.Empty;

    /// <summary>
    /// 指定された名称の店舗情報を取得する。
    /// </summary>
    public async Task<IReadOnlyList<Restaurant>> SearchAsync(Location currentLocation)
    {
        // リクルート WEBサービスのグルメサーチAPIを利用し、周辺のレストラン情報を取得する
        // Web APIを呼び出しJSONで結果を取得した後、Json.NETを利用してオブジェクト化する
        var json = await HttpClient.GetStringAsync(
            $"{Endpoint}" +
            $"?key={ApiKey}" +
            $"&lat={currentLocation.Latitude}" +
            $"&lng={currentLocation.Longitude}" +
            $"&format=json&type=lite");

        // JSONをデシリアライズする。
        return JsonSerializer.Deserialize<GourmetSearchResult>(json)!
            .Results
            .Shops
            .Select(x => new Restaurant(x.Genre.Name, x.Name))
            .ToArray();
    }
}