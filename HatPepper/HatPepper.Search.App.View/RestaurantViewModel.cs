using HatPepper.Search.App.Domain;

namespace HatPepper.Search.App.View;

public record RestaurantViewModel(int No, Restaurant Restaurant)
{
    public string Genre => Restaurant.Genre;
    public string Name => Restaurant.Name;

    public override string ToString() => $"{No}.{Restaurant.Name}";
}