using UnitGenerator;

namespace HatPepper.Search.Domain;

/// <summary>
/// レストランを識別するための一意な識別子を表す構造体です。
/// この構造体は、文字列ベースの単位型として、システム上で各レストランを一意に識別するために使用されます。
/// </summary>
[UnitOf<string>]
public partial struct RestaurantId;
