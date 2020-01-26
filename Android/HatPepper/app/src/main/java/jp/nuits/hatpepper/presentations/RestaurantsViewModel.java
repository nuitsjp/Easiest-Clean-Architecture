package jp.nuits.hatpepper.presentations;

import android.renderscript.RSInvalidStateException;
import android.widget.ArrayAdapter;

import androidx.core.util.Consumer;
import androidx.lifecycle.ViewModel;

import java.io.IOException;
import java.util.List;

import javax.inject.Inject;

import jp.nuits.hatpepper.usecases.ReferRestaurants;
import jp.nuits.hatpepper.usecases.Restaurant;

public class RestaurantsViewModel extends ViewModel {

    private final ReferRestaurants referRestaurants;

    @Inject
    public RestaurantsViewModel(ReferRestaurants referRestaurants)
    {
        this.referRestaurants = referRestaurants;
    }

    public void findRestaurants(Consumer<List<Restaurant>> consumer)
    {
        referRestaurants.Find(consumer);
    }
}
