namespace HatPepper.Search.View;

public record RestaurantViewModel(int No, Restaurant Restaurant)
{
    public string Genre => Restaurant.Genre;
    public string Name => Restaurant.Name;

    public override string ToString() => $"{No}.{Restaurant.Name}";
}