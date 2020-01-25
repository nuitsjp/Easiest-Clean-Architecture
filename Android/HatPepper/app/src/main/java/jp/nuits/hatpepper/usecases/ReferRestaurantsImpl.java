package jp.nuits.hatpepper.usecases;

import jp.nuits.hatpepper.entities.GourmetSearchApi;

public class ReferRestaurantsImpl implements ReferRestaurants {
    private final GourmetSearchApi gourmetSearchApi;

    public ReferRestaurantsImpl(GourmetSearchApi gourmetSearchApi) {
        this.gourmetSearchApi = gourmetSearchApi;
    }
}
