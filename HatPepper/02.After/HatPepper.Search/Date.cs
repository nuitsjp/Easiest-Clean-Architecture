using UnitGenerator;

namespace HatPepper;

/// <summary>
/// 年月日を表す構造体です。
/// この構造体は <see cref="DateTime"/> を基にしたユニット型として定義されています。
/// </summary>
[UnitOf<DateTime>]
public partial struct Date
{
    /// <summary>
    /// 現在の日付を表す <see cref="Date"/> のインスタンスを取得します。
    /// </summary>
    /// <value>
    /// システムの日付に基づく今日の日付を表します。
    /// </value>
    public static Date Today => (Date)DateTime.Today;
}
