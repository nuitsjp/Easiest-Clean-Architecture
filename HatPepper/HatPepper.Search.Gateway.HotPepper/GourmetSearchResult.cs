using System.Text.Json.Serialization;

namespace HatPepper.Booking.Gateway.HotPepper;

/// <summary>
/// 検索結果
/// </summary>
/// <param name="Results">結果</param>
public record GourmetSearchResult(
    [property: JsonPropertyName("results")] Results Results);