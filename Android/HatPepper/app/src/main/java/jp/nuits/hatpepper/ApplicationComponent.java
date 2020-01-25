package jp.nuits.hatpepper;

import dagger.Component;
import jp.nuits.hatpepper.infrastructures.InfrastructureModule;
import jp.nuits.hatpepper.presentations.RestaurantsFragment;
import jp.nuits.hatpepper.usecases.UseCaseModule;

@Component(
        modules = {
                UseCaseModule.class,
                InfrastructureModule.class
        }
)
public interface ApplicationComponent {

    void inject(RestaurantsFragment restaurantsFragment);
}
