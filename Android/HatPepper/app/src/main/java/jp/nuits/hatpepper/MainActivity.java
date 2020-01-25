package jp.nuits.hatpepper;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import jp.nuits.hatpepper.presentations.RestaurantsFragment;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main_activity);
        if (savedInstanceState == null) {
            getSupportFragmentManager().beginTransaction()
                    .replace(R.id.container, RestaurantsFragment.newInstance())
                    .commitNow();
        }
    }
}
