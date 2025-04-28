namespace HatPepper.Search.Domain;

/// <summary>
/// 現在地の座標情報を取得するためのインターフェースです。
/// </summary>
public interface IGeoCoordinator
{
    /// <summary>
    /// 現在地の座標情報を非同期で取得します。
    /// </summary>
    /// <returns>現在地の <see cref="Location"/> を表すタスクです。</returns>
    Task<Location> GetCurrentAsync();
}