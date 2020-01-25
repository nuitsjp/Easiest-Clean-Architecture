package jp.nuits.hatpepper;

import android.app.Application;

public class HatPepperApplication extends Application {
    public ApplicationComponent getAppComponent() {
        return appComponent;
    }

    // Reference to the application graph that is used across the whole app
    ApplicationComponent appComponent = DaggerApplicationComponent.create();

}
