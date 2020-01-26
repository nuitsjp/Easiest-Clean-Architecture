package jp.nuits.hatpepper;

import javax.inject.Singleton;

import dagger.Component;
import jp.nuits.hatpepper.infrastructures.InfrastructureModule;
import jp.nuits.hatpepper.presentations.RestaurantsFragment;
import jp.nuits.hatpepper.usecases.UseCaseModule;

@Singleton
@Component(
        modules = {
                UseCaseModule.class,
                InfrastructureModule.class
        }
)
public interface ApplicationComponent {

    void inject(RestaurantsFragment restaurantsFragment);
}
