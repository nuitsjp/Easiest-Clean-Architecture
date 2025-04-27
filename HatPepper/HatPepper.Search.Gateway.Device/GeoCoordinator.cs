namespace HatPepper.Search.Gateway.Device;

/// <summary>
/// 端末の位置情報を取得する
/// </summary>
public class GeoCoordinator : IGeoCoordinator
{
    /// <summary>
    /// 現在地を取得する
    /// </summary>
    public Location GetCurrent()
    {
        // 東京駅の緯度・経度を返却する
        return new Location(35.6809591d, 139.7673068d);
    }
}