package jp.nuits.hatpepper.presentations;

import androidx.lifecycle.ViewModel;

import javax.inject.Inject;

import jp.nuits.hatpepper.usecases.ReferRestaurants;

public class RestaurantsViewModel extends ViewModel {

    private final ReferRestaurants referRestaurants;

    @Inject
    public RestaurantsViewModel(ReferRestaurants referRestaurants)
    {
        this.referRestaurants = referRestaurants;
    }
}
