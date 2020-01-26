package jp.nuits.hatpepper.usecases;

import javax.inject.Singleton;

import dagger.Module;
import dagger.Provides;
import jp.nuits.hatpepper.entities.GourmetSearchApi;

@Module
public class UseCaseModule {
    @Provides
    @Singleton
    public ReferRestaurants provideReferRestaurants(GourmetSearchApi gourmetSearchApi) {
        // Whenever Dagger needs to provide an instance of type LoginRetrofitService,
        // this code (the one inside the @Provides method) is run.
        return new ReferRestaurantsImpl(gourmetSearchApi);
    }

}
