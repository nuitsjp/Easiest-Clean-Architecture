
using System.Text.Json.Serialization;

namespace HatPepper.Booking.Gateway.HotPepper;

/// <summary>
/// 店舗
/// </summary>
/// <param name="Name">名称</param>
/// <param name="Genre">ジャンル</param>
public record Shop(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("genre")] Genre Genre);