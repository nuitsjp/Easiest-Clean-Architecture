package jp.nuits.hatpepper.infrastructures;

import dagger.Module;
import dagger.Provides;
import jp.nuits.hatpepper.entities.GourmetSearchApi;
import jp.nuits.hatpepper.usecases.ReferRestaurants;
import jp.nuits.hatpepper.usecases.ReferRestaurantsImpl;

@Module
public class InfrastructureModule {
    @Provides
    public GourmetSearchApi provideGourmetSearchApi() {
        // Whenever Dagger needs to provide an instance of type LoginRetrofitService,
        // this code (the one inside the @Provides method) is run.
        return new GourmetSearchApiImpl();
    }

}
