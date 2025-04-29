using System.Text.Json.Serialization;

namespace HatPepper.Search.Gateway.HotPepper;

/// <summary>
/// 結果
/// </summary>
/// <param name="ResultsStart">検索開始位置</param>
/// <param name="ResultsReturned">返却結果</param>
/// <param name="ApiVersion">APIバージョン</param>
/// <param name="Shops">店舗</param>
/// <param name="ResultsAvailable">検索結果件数</param>
public record Results(
    [property: JsonPropertyName("results_start")] int ResultsStart,
    [property: JsonPropertyName("results_returned")] string ResultsReturned,
    [property: JsonPropertyName("api_version")] string ApiVersion,
    [property: JsonPropertyName("shop")] Shop[] Shops,
    [property: JsonPropertyName("results_available")] int ResultsAvailable);