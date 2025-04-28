namespace HatPepper.Search.Domain;

/// <summary>
/// 座標情報を表す不変レコードです。
/// </summary>
/// <param name="Latitude">緯度を表します。</param>
/// <param name="Longitude">経度を表します。</param>
public record Location(double Latitude, double Longitude);
