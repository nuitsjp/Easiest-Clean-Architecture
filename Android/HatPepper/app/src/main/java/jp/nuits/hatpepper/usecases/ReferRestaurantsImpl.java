package jp.nuits.hatpepper.usecases;

import androidx.core.util.Consumer;

import java.util.ArrayList;
import java.util.List;

import jp.nuits.hatpepper.entities.GourmetSearchApi;
import jp.nuits.hatpepper.entities.Shop;

public class ReferRestaurantsImpl implements ReferRestaurants {
    private final GourmetSearchApi gourmetSearchApi;

    public ReferRestaurantsImpl(GourmetSearchApi gourmetSearchApi) {
        this.gourmetSearchApi = gourmetSearchApi;
    }

    @Override
    public void Find(Consumer<List<Restaurant>> consumer) {
        gourmetSearchApi.search((gourmetSearchResults) -> {
            ArrayList<Restaurant> restaurants = new ArrayList<Restaurant>();
            for (Shop shop : gourmetSearchResults.getResults().getShop())
            {
                restaurants.add(new Restaurant(shop.getName()));
            }
            consumer.accept(restaurants);
        });
    }
}
