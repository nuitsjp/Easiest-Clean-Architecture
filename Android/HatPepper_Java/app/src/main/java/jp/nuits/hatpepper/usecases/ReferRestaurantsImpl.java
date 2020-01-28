package jp.nuits.hatpepper.usecases;

import java.util.List;
import java.util.function.Consumer;

public class ReferRestaurantsImpl implements ReferRestaurants {
    private final GourmetSearchApi gourmetSearchApi;

    public ReferRestaurantsImpl(GourmetSearchApi gourmetSearchApi) {
        this.gourmetSearchApi = gourmetSearchApi;
    }

    @Override
    public void Find(Consumer<List<Restaurant>> consumer) {
        gourmetSearchApi.search(consumer);
    }
}
