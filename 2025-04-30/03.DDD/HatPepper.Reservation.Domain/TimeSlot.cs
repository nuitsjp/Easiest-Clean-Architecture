using UnitGenerator;

namespace HatPepper.Reservation.Domain;

/// <summary>
/// 日時情報を表す値オブジェクトです。
/// 予約可能な時間帯など、特定の用途で利用されます。
/// </summary>
[UnitOf<DateTime>]
public partial struct TimeSlot
{
    /// <summary>
    /// 指定した書式で日時を文字列として返します。
    /// </summary>
    /// <param name="format">日時の書式指定文字列です。</param>
    /// <returns>指定した書式で表現された日時の文字列です。</returns>
    public string ToString(string format)
    {
        return value.ToString(format);
    }

    /// <summary>
    /// 指定した書式の文字列から <see cref="TimeSlot"/> を生成します。
    /// </summary>
    /// <param name="s">解析対象の日時文字列です。</param>
    /// <param name="format">日時の書式指定文字列です。</param>
    /// <exception cref="FormatException">文字列が指定した書式と一致しない場合に発生します。</exception>
    /// <remarks>
    /// 内部的には <see cref="DateTime.ParseExact(string, string, IFormatProvider?)"/> を利用しています。
    /// </remarks>
    public static TimeSlot Parse(string s, string format)
    {
        return (TimeSlot)DateTime.ParseExact(s, format, null);
    }
}