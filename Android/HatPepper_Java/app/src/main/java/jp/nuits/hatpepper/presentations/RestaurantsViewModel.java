package jp.nuits.hatpepper.presentations;

import androidx.lifecycle.ViewModel;

import java.util.List;
import java.util.function.Consumer;

import jp.nuits.hatpepper.usecases.ReferRestaurants;
import jp.nuits.hatpepper.usecases.Restaurant;

public class RestaurantsViewModel extends ViewModel {

    private final ReferRestaurants referRestaurants;

    public RestaurantsViewModel(ReferRestaurants referRestaurants)
    {
        this.referRestaurants = referRestaurants;
    }

    public void findRestaurants(Consumer<List<Restaurant>> consumer)
    {
        referRestaurants.Find(consumer);
    }
}
