namespace HatPepper.Search.Gateway.Device;

/// <summary>
/// 端末の位置情報を取得する
/// </summary>
public class GeoCoordinator
{
    /// <summary>
    /// 現在地を取得する
    /// </summary>
    public Task<Location> GetCurrentAsync()
    {
        // 現在地を取得する
        return Task.FromResult(new Location(35.6809591d, 139.7673068d));
    }
}